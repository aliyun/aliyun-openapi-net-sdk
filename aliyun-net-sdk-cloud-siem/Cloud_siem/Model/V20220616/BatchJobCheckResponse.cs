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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class BatchJobCheckResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string errCode;

		private string requestId;

		private BatchJobCheck_Data data;

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

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
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

		public BatchJobCheck_Data Data
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

		public class BatchJobCheck_Data
		{

			private int? taskCount;

			private int? finishCount;

			private int? failedCount;

			private string taskStatus;

			private string configId;

			private string folderId;

			private List<BatchJobCheck_ErrTaskListItem> errTaskList;

			public int? TaskCount
			{
				get
				{
					return taskCount;
				}
				set	
				{
					taskCount = value;
				}
			}

			public int? FinishCount
			{
				get
				{
					return finishCount;
				}
				set	
				{
					finishCount = value;
				}
			}

			public int? FailedCount
			{
				get
				{
					return failedCount;
				}
				set	
				{
					failedCount = value;
				}
			}

			public string TaskStatus
			{
				get
				{
					return taskStatus;
				}
				set	
				{
					taskStatus = value;
				}
			}

			public string ConfigId
			{
				get
				{
					return configId;
				}
				set	
				{
					configId = value;
				}
			}

			public string FolderId
			{
				get
				{
					return folderId;
				}
				set	
				{
					folderId = value;
				}
			}

			public List<BatchJobCheck_ErrTaskListItem> ErrTaskList
			{
				get
				{
					return errTaskList;
				}
				set	
				{
					errTaskList = value;
				}
			}

			public class BatchJobCheck_ErrTaskListItem
			{

				private long? userId;

				private List<BatchJobCheck_ProductListItem> productList;

				public long? UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public List<BatchJobCheck_ProductListItem> ProductList
				{
					get
					{
						return productList;
					}
					set	
					{
						productList = value;
					}
				}

				public class BatchJobCheck_ProductListItem
				{

					private string productCode;

					private List<BatchJobCheck_LogListItem> logList;

					public string ProductCode
					{
						get
						{
							return productCode;
						}
						set	
						{
							productCode = value;
						}
					}

					public List<BatchJobCheck_LogListItem> LogList
					{
						get
						{
							return logList;
						}
						set	
						{
							logList = value;
						}
					}

					public class BatchJobCheck_LogListItem
					{

						private string productCode;

						private string logCode;

						private string regionCode;

						private string projectNamePattern;

						private string logStoreNamePattern;

						private string errorCode;

						public string ProductCode
						{
							get
							{
								return productCode;
							}
							set	
							{
								productCode = value;
							}
						}

						public string LogCode
						{
							get
							{
								return logCode;
							}
							set	
							{
								logCode = value;
							}
						}

						public string RegionCode
						{
							get
							{
								return regionCode;
							}
							set	
							{
								regionCode = value;
							}
						}

						public string ProjectNamePattern
						{
							get
							{
								return projectNamePattern;
							}
							set	
							{
								projectNamePattern = value;
							}
						}

						public string LogStoreNamePattern
						{
							get
							{
								return logStoreNamePattern;
							}
							set	
							{
								logStoreNamePattern = value;
							}
						}

						public string ErrorCode
						{
							get
							{
								return errorCode;
							}
							set	
							{
								errorCode = value;
							}
						}
					}
				}
			}
		}
	}
}
