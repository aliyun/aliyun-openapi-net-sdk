/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.alimt.Model.V20181012
{
	public class GetTitleDiagnoseResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string message;

		private GetTitleDiagnose_Data data;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public GetTitleDiagnose_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetTitleDiagnose_Data
		{

			private string containCoreClasses;

			private string overLengthLimit;

			private string wordSpelledCorrectError;

			private string allUppercaseWords;

			private string noFirstUppercaseList;

			private string duplicateWords;

			private string disableWords;

			private string wordCount;

			private string totalScore;

			private string languageQualityScore;

			public string ContainCoreClasses
			{
				get
				{
					return containCoreClasses;
				}
				set	
				{
					containCoreClasses = value;
				}
			}

			public string OverLengthLimit
			{
				get
				{
					return overLengthLimit;
				}
				set	
				{
					overLengthLimit = value;
				}
			}

			public string WordSpelledCorrectError
			{
				get
				{
					return wordSpelledCorrectError;
				}
				set	
				{
					wordSpelledCorrectError = value;
				}
			}

			public string AllUppercaseWords
			{
				get
				{
					return allUppercaseWords;
				}
				set	
				{
					allUppercaseWords = value;
				}
			}

			public string NoFirstUppercaseList
			{
				get
				{
					return noFirstUppercaseList;
				}
				set	
				{
					noFirstUppercaseList = value;
				}
			}

			public string DuplicateWords
			{
				get
				{
					return duplicateWords;
				}
				set	
				{
					duplicateWords = value;
				}
			}

			public string DisableWords
			{
				get
				{
					return disableWords;
				}
				set	
				{
					disableWords = value;
				}
			}

			public string WordCount
			{
				get
				{
					return wordCount;
				}
				set	
				{
					wordCount = value;
				}
			}

			public string TotalScore
			{
				get
				{
					return totalScore;
				}
				set	
				{
					totalScore = value;
				}
			}

			public string LanguageQualityScore
			{
				get
				{
					return languageQualityScore;
				}
				set	
				{
					languageQualityScore = value;
				}
			}
		}
	}
}
