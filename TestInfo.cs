using System;
using System.Collections.Generic;
using System.Text;

namespace DotDotApp
{
	public class TestInfo
	{
		public TimeSpan? totalTime;
		public int totalQuestions;
		public bool hasTimeLimit;
		public TimeSpan? elapsedTime;
		public int? correctAnswers;
		public double? scoreInGrade10;
		public TimeSpan? averageTimePerQuestion;
		public TimeSpan? averageTimePerQuestionScored;
		public TestInfo(int tQuestions, bool hasTimeLimit)
		{
			this.totalQuestions = tQuestions;
			this.hasTimeLimit = hasTimeLimit;
		}
		public void CalculateScoreInGrade10()
		{
			if (correctAnswers == null)
				throw new Exception("Correct answers is not specified");
			this.scoreInGrade10 = ((double)correctAnswers) / totalQuestions * 10;
		}
		public void CalculateAverageTimePerQuestion() {
			if (!hasTimeLimit)
				throw new Exception("Current test does not have time limit");
			double tSecs = totalTime.Value.TotalSeconds/totalQuestions;
			int mins = (int)tSecs / 60;
			int secs = (int)(tSecs - mins*60);
			this.averageTimePerQuestion = new TimeSpan(0, mins, secs);
		}
		public void CalculateAverageTimePerQuestionScored() {
			//if (!hasTimeLimit)
			//	throw new Exception("Current test does not have time limit");
			if (elapsedTime == null)
				throw new Exception("Elapsed time is not specified");
			double tSecs = elapsedTime.Value.TotalSeconds / totalQuestions;
			int mins = (int)tSecs / 60;
			int secs = (int)Math.Round(tSecs - mins*60);
			this.averageTimePerQuestionScored = new TimeSpan(0, mins, secs);
		}
	}
}
