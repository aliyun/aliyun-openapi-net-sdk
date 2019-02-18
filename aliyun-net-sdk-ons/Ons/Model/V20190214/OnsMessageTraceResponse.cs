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

namespace Aliyun.Acs.Ons.Model.V20190214
{
	public class OnsMessageTraceResponse : AcsResponse
	{

		private string requestId;

		private string helpUrl;

		private List<OnsMessageTrace_MessageTrack> data;

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

		public List<OnsMessageTrace_MessageTrack> Data
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

		public class OnsMessageTrace_MessageTrack
		{

			private string consumerGroup;

			private string trackType;

			private string exceptionDesc;

			private string instanceId;

			public string ConsumerGroup
			{
				get
				{
					return consumerGroup;
				}
				set	
				{
					consumerGroup = value;
				}
			}

			public string TrackType
			{
				get
				{
					return trackType;
				}
				set	
				{
					trackType = value;
				}
			}

			public string ExceptionDesc
			{
				get
				{
					return exceptionDesc;
				}
				set	
				{
					exceptionDesc = value;
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
		}
	}
}