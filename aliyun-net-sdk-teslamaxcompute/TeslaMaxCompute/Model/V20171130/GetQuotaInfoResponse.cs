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

namespace Aliyun.Acs.TeslaMaxCompute.Model.V20171130
{
	public class GetQuotaInfoResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private GetQuotaInfo_Data data;

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

		public GetQuotaInfo_Data Data
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

		public class GetQuotaInfo_Data
		{

			private int? total;

			private List<GetQuotaInfo_Instance> detail;

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

			public List<GetQuotaInfo_Instance> Detail
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

			public class GetQuotaInfo_Instance
			{

				private string project;

				private string instanceId;

				private string status;

				private string userAccount;

				private string nickName;

				private string cluster;

				private string runTime;

				public string Project
				{
					get
					{
						return project;
					}
					set	
					{
						project = value;
					}
				}

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
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

				public string UserAccount
				{
					get
					{
						return userAccount;
					}
					set	
					{
						userAccount = value;
					}
				}

				public string NickName
				{
					get
					{
						return nickName;
					}
					set	
					{
						nickName = value;
					}
				}

				public string Cluster
				{
					get
					{
						return cluster;
					}
					set	
					{
						cluster = value;
					}
				}

				public string RunTime
				{
					get
					{
						return runTime;
					}
					set	
					{
						runTime = value;
					}
				}
			}
		}
	}
}