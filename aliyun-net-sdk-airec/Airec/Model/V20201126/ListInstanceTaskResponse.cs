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

namespace Aliyun.Acs.Airec.Model.V20201126
{
	public class ListInstanceTaskResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private List<ListInstanceTask_ResultItem> result;

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

		public List<ListInstanceTask_ResultItem> Result
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

		public class ListInstanceTask_ResultItem
		{

			private string name;

			private int? totalProgress;

			private List<ListInstanceTask_SubProgressInfosItem> subProgressInfos;

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

			public int? TotalProgress
			{
				get
				{
					return totalProgress;
				}
				set	
				{
					totalProgress = value;
				}
			}

			public List<ListInstanceTask_SubProgressInfosItem> SubProgressInfos
			{
				get
				{
					return subProgressInfos;
				}
				set	
				{
					subProgressInfos = value;
				}
			}

			public class ListInstanceTask_SubProgressInfosItem
			{

				private string detail;

				private int? finishedNum;

				private int? progress;

				private int? totalNum;

				private string type;

				public string Detail
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

				public int? FinishedNum
				{
					get
					{
						return finishedNum;
					}
					set	
					{
						finishedNum = value;
					}
				}

				public int? Progress
				{
					get
					{
						return progress;
					}
					set	
					{
						progress = value;
					}
				}

				public int? TotalNum
				{
					get
					{
						return totalNum;
					}
					set	
					{
						totalNum = value;
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
			}
		}
	}
}
