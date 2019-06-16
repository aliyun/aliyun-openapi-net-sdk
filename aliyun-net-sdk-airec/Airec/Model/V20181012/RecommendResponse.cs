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

namespace Aliyun.Acs.Airec.Model.V20181012
{
	public class RecommendResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private List<Recommend_ResultItem> result;

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

		public List<Recommend_ResultItem> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class Recommend_ResultItem
		{

			private string traceId;

			private string itemId;

			private string itemType;

			private string matchInfo;

			private float? weight;

			private int? position;

			private string traceInfo;

			public string TraceId
			{
				get
				{
					return traceId;
				}
				set	
				{
					traceId = value;
				}
			}

			public string ItemId
			{
				get
				{
					return itemId;
				}
				set	
				{
					itemId = value;
				}
			}

			public string ItemType
			{
				get
				{
					return itemType;
				}
				set	
				{
					itemType = value;
				}
			}

			public string MatchInfo
			{
				get
				{
					return matchInfo;
				}
				set	
				{
					matchInfo = value;
				}
			}

			public float? Weight
			{
				get
				{
					return weight;
				}
				set	
				{
					weight = value;
				}
			}

			public int? Position
			{
				get
				{
					return position;
				}
				set	
				{
					position = value;
				}
			}

			public string TraceInfo
			{
				get
				{
					return traceInfo;
				}
				set	
				{
					traceInfo = value;
				}
			}
		}
	}
}
