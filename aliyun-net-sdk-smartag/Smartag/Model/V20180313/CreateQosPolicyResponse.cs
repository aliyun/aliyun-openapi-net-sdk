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

namespace Aliyun.Acs.Smartag.Model.V20180313
{
	public class CreateQosPolicyResponse : AcsResponse
	{

		private string requestId;

		private string qosId;

		private string qosPolicyId;

		private string description;

		private int? priority;

		private string sourceCidr;

		private string destCidr;

		private string ipProtocol;

		private string sourcePortRange;

		private string destPortRange;

		private string startTime;

		private string endTime;

		private string name;

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

		public string QosId
		{
			get
			{
				return qosId;
			}
			set	
			{
				qosId = value;
			}
		}

		public string QosPolicyId
		{
			get
			{
				return qosPolicyId;
			}
			set	
			{
				qosPolicyId = value;
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

		public int? Priority
		{
			get
			{
				return priority;
			}
			set	
			{
				priority = value;
			}
		}

		public string SourceCidr
		{
			get
			{
				return sourceCidr;
			}
			set	
			{
				sourceCidr = value;
			}
		}

		public string DestCidr
		{
			get
			{
				return destCidr;
			}
			set	
			{
				destCidr = value;
			}
		}

		public string IpProtocol
		{
			get
			{
				return ipProtocol;
			}
			set	
			{
				ipProtocol = value;
			}
		}

		public string SourcePortRange
		{
			get
			{
				return sourcePortRange;
			}
			set	
			{
				sourcePortRange = value;
			}
		}

		public string DestPortRange
		{
			get
			{
				return destPortRange;
			}
			set	
			{
				destPortRange = value;
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
			}
		}
	}
}
