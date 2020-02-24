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

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
	public class GetTagHitsSummaryResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private List<GetTagHitsSummary_TagHits> tagHitsList;

		private List<GetTagHitsSummary_TagGroup> tagGroups;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string Code
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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public List<GetTagHitsSummary_TagHits> TagHitsList
		{
			get
			{
				return tagHitsList;
			}
			set	
			{
				tagHitsList = value;
			}
		}

		public List<GetTagHitsSummary_TagGroup> TagGroups
		{
			get
			{
				return tagGroups;
			}
			set	
			{
				tagGroups = value;
			}
		}

		public class GetTagHitsSummary_TagHits
		{

			private string tagName;

			private int? hitCount;

			private string tagGroup;

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

			public int? HitCount
			{
				get
				{
					return hitCount;
				}
				set	
				{
					hitCount = value;
				}
			}

			public string TagGroup
			{
				get
				{
					return tagGroup;
				}
				set	
				{
					tagGroup = value;
				}
			}
		}

		public class GetTagHitsSummary_TagGroup
		{

			private string id;

			private int? tagGroupIndex;

			private string scriptId;

			private string tagGroup;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public int? TagGroupIndex
			{
				get
				{
					return tagGroupIndex;
				}
				set	
				{
					tagGroupIndex = value;
				}
			}

			public string ScriptId
			{
				get
				{
					return scriptId;
				}
				set	
				{
					scriptId = value;
				}
			}

			public string TagGroup
			{
				get
				{
					return tagGroup;
				}
				set	
				{
					tagGroup = value;
				}
			}
		}
	}
}
