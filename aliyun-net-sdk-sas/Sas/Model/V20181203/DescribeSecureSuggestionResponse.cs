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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeSecureSuggestionResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private List<DescribeSecureSuggestion_Suggestion> suggestions;

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

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

		public List<DescribeSecureSuggestion_Suggestion> Suggestions
		{
			get
			{
				return suggestions;
			}
			set	
			{
				suggestions = value;
			}
		}

		public class DescribeSecureSuggestion_Suggestion
		{

			private int? points;

			private string suggestType;

			private List<DescribeSecureSuggestion_DetailItem> detail;

			public int? Points
			{
				get
				{
					return points;
				}
				set	
				{
					points = value;
				}
			}

			public string SuggestType
			{
				get
				{
					return suggestType;
				}
				set	
				{
					suggestType = value;
				}
			}

			public List<DescribeSecureSuggestion_DetailItem> Detail
			{
				get
				{
					return detail;
				}
				set	
				{
					detail = value;
				}
			}

			public class DescribeSecureSuggestion_DetailItem
			{

				private string title;

				private string description;

				private string subType;

				public string Title
				{
					get
					{
						return title;
					}
					set	
					{
						title = value;
					}
				}

				public string Description
				{
					get
					{
						return description;
					}
					set	
					{
						description = value;
					}
				}

				public string SubType
				{
					get
					{
						return subType;
					}
					set	
					{
						subType = value;
					}
				}
			}
		}
	}
}
