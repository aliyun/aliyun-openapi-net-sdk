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

namespace Aliyun.Acs.Dyvmsapi.Model.V20170525
{
	public class ListCallTaskResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private long? pageNumber;

		private long? pageSize;

		private long? total;

		private List<ListCallTask_DataItem> data;

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

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public long? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<ListCallTask_DataItem> Data
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

		public class ListCallTask_DataItem
		{

			private long? id;

			private string taskName;

			private string templateName;

			private string bizType;

			private string resource;

			private string fireTime;

			private string completeTime;

			private string status;

			private string stopTime;

			private string templateCode;

			private string data;

			private string dataType;

			private long? totalCount;

			private long? completedCount;

			private int? completedRate;

			public long? Id
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

			public string TaskName
			{
				get
				{
					return taskName;
				}
				set	
				{
					taskName = value;
				}
			}

			public string TemplateName
			{
				get
				{
					return templateName;
				}
				set	
				{
					templateName = value;
				}
			}

			public string BizType
			{
				get
				{
					return bizType;
				}
				set	
				{
					bizType = value;
				}
			}

			public string Resource
			{
				get
				{
					return resource;
				}
				set	
				{
					resource = value;
				}
			}

			public string FireTime
			{
				get
				{
					return fireTime;
				}
				set	
				{
					fireTime = value;
				}
			}

			public string CompleteTime
			{
				get
				{
					return completeTime;
				}
				set	
				{
					completeTime = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string StopTime
			{
				get
				{
					return stopTime;
				}
				set	
				{
					stopTime = value;
				}
			}

			public string TemplateCode
			{
				get
				{
					return templateCode;
				}
				set	
				{
					templateCode = value;
				}
			}

			public string Data
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

			public string DataType
			{
				get
				{
					return dataType;
				}
				set	
				{
					dataType = value;
				}
			}

			public long? TotalCount
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

			public long? CompletedCount
			{
				get
				{
					return completedCount;
				}
				set	
				{
					completedCount = value;
				}
			}

			public int? CompletedRate
			{
				get
				{
					return completedRate;
				}
				set	
				{
					completedRate = value;
				}
			}
		}
	}
}
