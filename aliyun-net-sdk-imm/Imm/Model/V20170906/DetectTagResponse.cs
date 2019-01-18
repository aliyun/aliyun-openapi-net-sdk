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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class DetectTagResponse : AcsResponse
	{

		private string requestId;

		private string successNum;

		private List<DetectTag_SuccessDetailsItem> successDetails;

		private List<DetectTag_FailDetailsItem> failDetails;

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

		public string SuccessNum
		{
			get
			{
				return successNum;
			}
			set	
			{
				successNum = value;
			}
		}

		public List<DetectTag_SuccessDetailsItem> SuccessDetails
		{
			get
			{
				return successDetails;
			}
			set	
			{
				successDetails = value;
			}
		}

		public List<DetectTag_FailDetailsItem> FailDetails
		{
			get
			{
				return failDetails;
			}
			set	
			{
				failDetails = value;
			}
		}

		public class DetectTag_SuccessDetailsItem
		{

			private string srcUri;

			private List<DetectTag_TagsItem> tags;

			public string SrcUri
			{
				get
				{
					return srcUri;
				}
				set	
				{
					srcUri = value;
				}
			}

			public List<DetectTag_TagsItem> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public class DetectTag_TagsItem
			{

				private string tagId;

				private string tagLevel;

				private string tagName;

				private string parentTagId;

				private string parentTagName;

				private string tagScore;

				public string TagId
				{
					get
					{
						return tagId;
					}
					set	
					{
						tagId = value;
					}
				}

				public string TagLevel
				{
					get
					{
						return tagLevel;
					}
					set	
					{
						tagLevel = value;
					}
				}

				public string TagName
				{
					get
					{
						return tagName;
					}
					set	
					{
						tagName = value;
					}
				}

				public string ParentTagId
				{
					get
					{
						return parentTagId;
					}
					set	
					{
						parentTagId = value;
					}
				}

				public string ParentTagName
				{
					get
					{
						return parentTagName;
					}
					set	
					{
						parentTagName = value;
					}
				}

				public string TagScore
				{
					get
					{
						return tagScore;
					}
					set	
					{
						tagScore = value;
					}
				}
			}
		}

		public class DetectTag_FailDetailsItem
		{

			private string srcUri;

			private string reason;

			public string SrcUri
			{
				get
				{
					return srcUri;
				}
				set	
				{
					srcUri = value;
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
		}
	}
}