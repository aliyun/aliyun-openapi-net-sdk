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

namespace Aliyun.Acs.Ons.Model.V20190214
{
	public class OnsInstanceBaseInfoResponse : AcsResponse
	{

		private string requestId;

		private string helpUrl;

		private OnsInstanceBaseInfo_InstanceBaseInfo instanceBaseInfo;

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

		public string HelpUrl
		{
			get
			{
				return helpUrl;
			}
			set	
			{
				helpUrl = value;
			}
		}

		public OnsInstanceBaseInfo_InstanceBaseInfo InstanceBaseInfo
		{
			get
			{
				return instanceBaseInfo;
			}
			set	
			{
				instanceBaseInfo = value;
			}
		}

		public class OnsInstanceBaseInfo_InstanceBaseInfo
		{

			private bool? independentNaming;

			private long? maxTps;

			private string remark;

			private string instanceName;

			private long? releaseTime;

			private int? topicCapacity;

			private int? instanceStatus;

			private string instanceId;

			private int? instanceType;

			private OnsInstanceBaseInfo_Endpoints endpoints;

			public bool? IndependentNaming
			{
				get
				{
					return independentNaming;
				}
				set	
				{
					independentNaming = value;
				}
			}

			public long? MaxTps
			{
				get
				{
					return maxTps;
				}
				set	
				{
					maxTps = value;
				}
			}

			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public long? ReleaseTime
			{
				get
				{
					return releaseTime;
				}
				set	
				{
					releaseTime = value;
				}
			}

			public int? TopicCapacity
			{
				get
				{
					return topicCapacity;
				}
				set	
				{
					topicCapacity = value;
				}
			}

			public int? InstanceStatus
			{
				get
				{
					return instanceStatus;
				}
				set	
				{
					instanceStatus = value;
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

			public int? InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			public OnsInstanceBaseInfo_Endpoints Endpoints
			{
				get
				{
					return endpoints;
				}
				set	
				{
					endpoints = value;
				}
			}

			public class OnsInstanceBaseInfo_Endpoints
			{

				private string tcpEndpoint;

				private string httpInternetEndpoint;

				private string httpInternalEndpoint;

				private string httpInternetSecureEndpoint;

				public string TcpEndpoint
				{
					get
					{
						return tcpEndpoint;
					}
					set	
					{
						tcpEndpoint = value;
					}
				}

				public string HttpInternetEndpoint
				{
					get
					{
						return httpInternetEndpoint;
					}
					set	
					{
						httpInternetEndpoint = value;
					}
				}

				public string HttpInternalEndpoint
				{
					get
					{
						return httpInternalEndpoint;
					}
					set	
					{
						httpInternalEndpoint = value;
					}
				}

				public string HttpInternetSecureEndpoint
				{
					get
					{
						return httpInternetSecureEndpoint;
					}
					set	
					{
						httpInternetSecureEndpoint = value;
					}
				}
			}
		}
	}
}
