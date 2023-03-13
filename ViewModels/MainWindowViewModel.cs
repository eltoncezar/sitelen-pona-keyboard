using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using Avalonia;
using ReactiveUI;
using SitelenPonaKeyboard.Resources;

namespace SitelenPonaKeyboard.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private List<Glyph> Result = new List<Glyph>();

        // public List<Glyph> Result
        // {
        //     get => result;
        //     set => this.RaiseAndSetIfChanged(ref result, value);
        // }

        private string content;
        public string Content {
            get => content;
            set => this.RaiseAndSetIfChanged(ref content, value);
        }

        private int caretPosition;

        public int CaretPosition
        {
            get => caretPosition;
            set => this.RaiseAndSetIfChanged(ref caretPosition, value);
        }

        public string SitelenPona => string.Join("", Result.Select(g => g.Value));

        public string Latin => string.Join(" ", Result.Select(g => g.Name)) + " ";


        private void AppendText(Glyph glyph)
        {
            // // if (Latin.Length <= 0) return;
            // var latin = Latin;
            //
            // var length = CaretPosition > latin.Length ? latin.Length : CaretPosition;
            // var subs = latin.Substring(0, length);
            // var wordCount = subs.Count(c => c == ' ');
            // if (wordCount < Result.Count)
            // {
            //     wordCount++;
            // }
            //
            // Result.Insert(wordCount, glyph);
            // latin = Latin;
            //
            // CaretPosition += glyph.Name.Length+1;
            // if (CaretPosition > latin.Length)
            // {
            //     CaretPosition = latin.Length;
            // }

            Result.Add(glyph);

            this.RaisePropertyChanged(nameof(SitelenPona));
            this.RaisePropertyChanged(nameof(Latin));
        }

        private async void CopyText()
        {
            await Application.Current?.Clipboard?.SetTextAsync(SitelenPona)!;
        }

        private void Backspace()
        {
            if (Result.Count <= 0) return;

            Result.RemoveAt(Result.Count - 1);
            this.RaisePropertyChanged(nameof(SitelenPona));
            this.RaisePropertyChanged(nameof(Latin));
        }

        private void ClearText()
        {
            Result.Clear();
            this.RaisePropertyChanged(nameof(SitelenPona));
            this.RaisePropertyChanged(nameof(Latin));
        }

        public void ParseContent(string text)
        {
            if (text == null)
            {
                return;
            }

            var result = "";
            var punctuation = new Dictionary<string, string>
            {
                {"!", Glyphs.exclamation.Name},
                {"?", Glyphs.question.Name},
                {".", Glyphs.period.Name},
                {",", Glyphs.comma.Name},
                {":", Glyphs.colon.Name},
                {";", Glyphs.semicolon.Name}
            };

            foreach (var kvp in punctuation)
            {
                text = text.Replace(kvp.Key, " " + kvp.Value + " ");
            }

            var words = text
                .Replace("  ", " ")
                .ToLower()
                .Split(" ");

            var changed = false;

            foreach (var word in words)
            {
                if (string.IsNullOrEmpty(word)) continue;

                if (Glyphs.TryParse(word, out var parsed))
                {
                    result += parsed.Value;
                    // changed = true;
                }
                else
                {
                    result += word;
                }
            }

            // if (changed)
            // {
                Content = result;
            // }
        }

        public void Parse(string text)
        {
            Result.Clear();

            var punctuation = new Dictionary<string, string>
            {
                {"!", Glyphs.exclamation.Name},
                {"?", Glyphs.question.Name},
                {".", Glyphs.period.Name},
                {",", Glyphs.comma.Name},
                {":", Glyphs.colon.Name},
                {";", Glyphs.semicolon.Name}
            };

            foreach (var kvp in punctuation)
            {
                text = text.Replace(kvp.Key, " " + kvp.Value + " ");
            }

            var words = text
                .Replace("  ", " ")
                .ToLower()
                .Split(" ");

            foreach (var word in words)
            {
                if (string.IsNullOrEmpty(word)) continue;

                if (Glyphs.TryParse(word, out var result))
                {
                    Result.Add(result);
                }
            }

            this.RaisePropertyChanged(nameof(SitelenPona));
            // this.RaisePropertyChanged(nameof(Latin));
        }
    }
}