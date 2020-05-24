using System.Text;

namespace RhombusOfStars
{
    public class RhombusDrawerAsString
    {
        public string Draw(int countOfStars)
        {
            StringBuilder sb = new StringBuilder();
            this.TopPart(sb, countOfStars);
            this.DrawLineOfStars(sb, countOfStars);
            this.BottomPart(sb, countOfStars);

            return sb.ToString();
        }
        private void TopPart(StringBuilder sb, int numberOfStars)
        {
            for (int i = 1; i <= numberOfStars-1; i++)
            {
                sb.Append(new string(' ', numberOfStars - i));
                DrawLineOfStars(sb, i);
            }
        }
        private void BottomPart(StringBuilder sb, int numberOfStars)
        {
            for (int i = numberOfStars - 1; i >= 1; i--)
            {
                sb.Append(new string(' ', numberOfStars - i));
                DrawLineOfStars(sb, i);

            }
        }
        private void DrawLineOfStars(StringBuilder sb, int numberOfStars)
        {
            for (int stars = 0; stars < numberOfStars; stars++)
            {
                sb.Append('*');
                if (stars < numberOfStars - 1)
                {
                    sb.Append(' ');
                }
            }
            sb.AppendLine();
        }
    }
}
