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

namespace Aliyun.Acs.Linkvisual.Model.V20180120
{
	public class QueryLocalFileUploadJobResponse : AcsResponse
	{

		private string code;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private QueryLocalFileUploadJob_Data data;

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

		public QueryLocalFileUploadJob_Data Data
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

		public class QueryLocalFileUploadJob_Data
		{

			private int? status;

			private List<QueryLocalFileUploadJob_ResultListItem> resultList;

			public int? Status
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

			public List<QueryLocalFileUploadJob_ResultListItem> ResultList
			{
				get
				{
					return resultList;
				}
				set	
				{
					resultList = value;
				}
			}

			public class QueryLocalFileUploadJob_ResultListItem
			{

				private int? slotEndTime;

				private string productKey;

				private string deviceName;

				private int? slotStartTime;

				private int? code;

				private int? slotStatus;

				private string iotId;

				private List<QueryLocalFileUploadJob_FileListItem> fileList;

				public int? SlotEndTime
				{
					get
					{
						return slotEndTime;
					}
					set	
					{
						slotEndTime = value;
					}
				}

				public string ProductKey
				{
					get
					{
						return productKey;
					}
					set	
					{
						productKey = value;
					}
				}

				public string DeviceName
				{
					get
					{
						return deviceName;
					}
					set	
					{
						deviceName = value;
					}
				}

				public int? SlotStartTime
				{
					get
					{
						return slotStartTime;
					}
					set	
					{
						slotStartTime = value;
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

				public int? SlotStatus
				{
					get
					{
						return slotStatus;
					}
					set	
					{
						slotStatus = value;
					}
				}

				public string IotId
				{
					get
					{
						return iotId;
					}
					set	
					{
						iotId = value;
					}
				}

				public List<QueryLocalFileUploadJob_FileListItem> FileList
				{
					get
					{
						return fileList;
					}
					set	
					{
						fileList = value;
					}
				}

				public class QueryLocalFileUploadJob_FileListItem
				{

					private string fileName;

					private int? fileStartTime;

					private int? fileEndTime;

					public string FileName
					{
						get
						{
							return fileName;
						}
						set	
						{
							fileName = value;
						}
					}

					public int? FileStartTime
					{
						get
						{
							return fileStartTime;
						}
						set	
						{
							fileStartTime = value;
						}
					}

					public int? FileEndTime
					{
						get
						{
							return fileEndTime;
						}
						set	
						{
							fileEndTime = value;
						}
					}
				}
			}
		}
	}
}
