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

namespace Aliyun.Acs.nis.Model.V20211216
{
	public class GetNatTopNResponse : AcsResponse
	{

		private string requestId;

		private bool? isTopNOpen;

		private List<GetNatTopN_NatGatewayTopNItem> natGatewayTopN;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "IsTopNOpen")]
		public bool? IsTopNOpen
		{
			get
			{
				return isTopNOpen;
			}
			set	
			{
				isTopNOpen = value;
			}
		}

		[JsonProperty(PropertyName = "NatGatewayTopN")]
		public List<GetNatTopN_NatGatewayTopNItem> NatGatewayTopN
		{
			get
			{
				return natGatewayTopN;
			}
			set	
			{
				natGatewayTopN = value;
			}
		}

		public class GetNatTopN_NatGatewayTopNItem
		{

			private string ip;

			private float? inBps;

			private float? outBps;

			private float? inPps;

			private float? outPps;

			private float? inFlowPerMinute;

			private float? outFlowPerMinute;

			private float? newSessionPerSecond;

			private float? activeSessionCount;

			[JsonProperty(PropertyName = "Ip")]
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

			[JsonProperty(PropertyName = "InBps")]
			public float? InBps
			{
				get
				{
					return inBps;
				}
				set	
				{
					inBps = value;
				}
			}

			[JsonProperty(PropertyName = "OutBps")]
			public float? OutBps
			{
				get
				{
					return outBps;
				}
				set	
				{
					outBps = value;
				}
			}

			[JsonProperty(PropertyName = "InPps")]
			public float? InPps
			{
				get
				{
					return inPps;
				}
				set	
				{
					inPps = value;
				}
			}

			[JsonProperty(PropertyName = "OutPps")]
			public float? OutPps
			{
				get
				{
					return outPps;
				}
				set	
				{
					outPps = value;
				}
			}

			[JsonProperty(PropertyName = "InFlowPerMinute")]
			public float? InFlowPerMinute
			{
				get
				{
					return inFlowPerMinute;
				}
				set	
				{
					inFlowPerMinute = value;
				}
			}

			[JsonProperty(PropertyName = "OutFlowPerMinute")]
			public float? OutFlowPerMinute
			{
				get
				{
					return outFlowPerMinute;
				}
				set	
				{
					outFlowPerMinute = value;
				}
			}

			[JsonProperty(PropertyName = "NewSessionPerSecond")]
			public float? NewSessionPerSecond
			{
				get
				{
					return newSessionPerSecond;
				}
				set	
				{
					newSessionPerSecond = value;
				}
			}

			[JsonProperty(PropertyName = "ActiveSessionCount")]
			public float? ActiveSessionCount
			{
				get
				{
					return activeSessionCount;
				}
				set	
				{
					activeSessionCount = value;
				}
			}
		}
	}
}
