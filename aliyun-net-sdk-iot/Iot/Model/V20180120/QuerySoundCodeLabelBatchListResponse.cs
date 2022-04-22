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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class QuerySoundCodeLabelBatchListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private QuerySoundCodeLabelBatchList_Data data;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public QuerySoundCodeLabelBatchList_Data Data
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

		public class QuerySoundCodeLabelBatchList_Data
		{

			private int? total;

			private int? pageId;

			private int? pageSize;

			private List<QuerySoundCodeLabelBatchList_Items> list;

			public int? Total
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

			public int? PageId
			{
				get
				{
					return pageId;
				}
				set	
				{
					pageId = value;
				}
			}

			public int? PageSize
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

			public List<QuerySoundCodeLabelBatchList_Items> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class QuerySoundCodeLabelBatchList_Items
			{

				private string batchCode;

				private string description;

				private int? total;

				private int? successNum;

				private string status;

				private long? gmtCreate;

				public string BatchCode
				{
					get
					{
						return batchCode;
					}
					set	
					{
						batchCode = value;
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

				public int? Total
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

				public int? SuccessNum
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

				public long? GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}
			}
		}
	}
}
