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

namespace Aliyun.Acs.Qualitycheck.Model.V20190115
{
	public class GetDataSetListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? count;

		private List<GetDataSetList_DataSet> data;

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

		public int? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
			}
		}

		public List<GetDataSetList_DataSet> Data
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

		public class GetDataSetList_DataSet
		{

			private long? setId;

			private string setName;

			private string setDomain;

			private string setRoleArn;

			private string setBucketName;

			private string setFolderName;

			private int? channelType;

			private int? createType;

			private string createTime;

			private string updateTime;

			private int? setNumber;

			public long? SetId
			{
				get
				{
					return setId;
				}
				set	
				{
					setId = value;
				}
			}

			public string SetName
			{
				get
				{
					return setName;
				}
				set	
				{
					setName = value;
				}
			}

			public string SetDomain
			{
				get
				{
					return setDomain;
				}
				set	
				{
					setDomain = value;
				}
			}

			public string SetRoleArn
			{
				get
				{
					return setRoleArn;
				}
				set	
				{
					setRoleArn = value;
				}
			}

			public string SetBucketName
			{
				get
				{
					return setBucketName;
				}
				set	
				{
					setBucketName = value;
				}
			}

			public string SetFolderName
			{
				get
				{
					return setFolderName;
				}
				set	
				{
					setFolderName = value;
				}
			}

			public int? ChannelType
			{
				get
				{
					return channelType;
				}
				set	
				{
					channelType = value;
				}
			}

			public int? CreateType
			{
				get
				{
					return createType;
				}
				set	
				{
					createType = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public int? SetNumber
			{
				get
				{
					return setNumber;
				}
				set	
				{
					setNumber = value;
				}
			}
		}
	}
}
