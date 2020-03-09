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

namespace Aliyun.Acs.nlp_automl.Model.V20191111
{
	public class RunContactReviewResponse : AcsResponse
	{

		private string requestId;

		private string rawContractContent;

		private RunContactReview_ContactContent contactContent;

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

		public string RawContractContent
		{
			get
			{
				return rawContractContent;
			}
			set	
			{
				rawContractContent = value;
			}
		}

		public RunContactReview_ContactContent ContactContent
		{
			get
			{
				return contactContent;
			}
			set	
			{
				contactContent = value;
			}
		}

		public class RunContactReview_ContactContent
		{

			private List<RunContactReview_ReviewResult> reviewResults;

			private List<RunContactReview_StructureResult> structureResults;

			public List<RunContactReview_ReviewResult> ReviewResults
			{
				get
				{
					return reviewResults;
				}
				set	
				{
					reviewResults = value;
				}
			}

			public List<RunContactReview_StructureResult> StructureResults
			{
				get
				{
					return structureResults;
				}
				set	
				{
					structureResults = value;
				}
			}

			public class RunContactReview_ReviewResult
			{

				private string riskLevel;

				private string reason;

				private string type;

				private string modificationSuggestion;

				private List<string> _value;

				private List<string> endPosition;

				private List<string> startPosition;

				public string RiskLevel
				{
					get
					{
						return riskLevel;
					}
					set	
					{
						riskLevel = value;
					}
				}

				public string Reason
				{
					get
					{
						return reason;
					}
					set	
					{
						reason = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string ModificationSuggestion
				{
					get
					{
						return modificationSuggestion;
					}
					set	
					{
						modificationSuggestion = value;
					}
				}

				public List<string> _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}

				public List<string> EndPosition
				{
					get
					{
						return endPosition;
					}
					set	
					{
						endPosition = value;
					}
				}

				public List<string> StartPosition
				{
					get
					{
						return startPosition;
					}
					set	
					{
						startPosition = value;
					}
				}
			}

			public class RunContactReview_StructureResult
			{

				private string name;

				private string type;

				private List<string> _value1;

				private List<string> endPosition2;

				private List<string> startPosition3;

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public List<string> _Value1
				{
					get
					{
						return _value1;
					}
					set	
					{
						_value1 = value;
					}
				}

				public List<string> EndPosition2
				{
					get
					{
						return endPosition2;
					}
					set	
					{
						endPosition2 = value;
					}
				}

				public List<string> StartPosition3
				{
					get
					{
						return startPosition3;
					}
					set	
					{
						startPosition3 = value;
					}
				}
			}
		}
	}
}
