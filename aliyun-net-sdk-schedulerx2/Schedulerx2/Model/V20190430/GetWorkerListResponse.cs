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

namespace Aliyun.Acs.schedulerx2.Model.V20190430
{
	public class GetWorkerListResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string message;

		private bool? success;

		private GetWorkerList_Data data;

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

		public GetWorkerList_Data Data
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

		public class GetWorkerList_Data
		{

			private List<GetWorkerList_WorkerInfo> workerInfos;

			public List<GetWorkerList_WorkerInfo> WorkerInfos
			{
				get
				{
					return workerInfos;
				}
				set	
				{
					workerInfos = value;
				}
			}

			public class GetWorkerList_WorkerInfo
			{

				private string ip;

				private int? port;

				private string workerAddress;

				private string label;

				private string version;

				private string starter;

				public string Ip
				{
					get
					{
						return ip;
					}
					set	
					{
						ip = value;
					}
				}

				public int? Port
				{
					get
					{
						return port;
					}
					set	
					{
						port = value;
					}
				}

				public string WorkerAddress
				{
					get
					{
						return workerAddress;
					}
					set	
					{
						workerAddress = value;
					}
				}

				public string Label
				{
					get
					{
						return label;
					}
					set	
					{
						label = value;
					}
				}

				public string Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}

				public string Starter
				{
					get
					{
						return starter;
					}
					set	
					{
						starter = value;
					}
				}
			}
		}
	}
}
