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
	public class CreateAndAnalyzeNetworkPathResponse : AcsResponse
	{

		private string requestId;

		private string networkReachableAnalysisId;

		private string sourceId;

		private string targetId;

		private string sourceType;

		private string targetType;

		private string sourcePort;

		private string targetPort;

		private string protocol;

		private string sourceIpAddress;

		private string targetIpAddress;

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

		public string NetworkReachableAnalysisId
		{
			get
			{
				return networkReachableAnalysisId;
			}
			set	
			{
				networkReachableAnalysisId = value;
			}
		}

		public string SourceId
		{
			get
			{
				return sourceId;
			}
			set	
			{
				sourceId = value;
			}
		}

		public string TargetId
		{
			get
			{
				return targetId;
			}
			set	
			{
				targetId = value;
			}
		}

		public string SourceType
		{
			get
			{
				return sourceType;
			}
			set	
			{
				sourceType = value;
			}
		}

		public string TargetType
		{
			get
			{
				return targetType;
			}
			set	
			{
				targetType = value;
			}
		}

		public string SourcePort
		{
			get
			{
				return sourcePort;
			}
			set	
			{
				sourcePort = value;
			}
		}

		public string TargetPort
		{
			get
			{
				return targetPort;
			}
			set	
			{
				targetPort = value;
			}
		}

		public string Protocol
		{
			get
			{
				return protocol;
			}
			set	
			{
				protocol = value;
			}
		}

		public string SourceIpAddress
		{
			get
			{
				return sourceIpAddress;
			}
			set	
			{
				sourceIpAddress = value;
			}
		}

		public string TargetIpAddress
		{
			get
			{
				return targetIpAddress;
			}
			set	
			{
				targetIpAddress = value;
			}
		}
	}
}
