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

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribeInstanceSpecsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeInstanceSpecs_InstanceSpec> instanceSpecs;

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

		public List<DescribeInstanceSpecs_InstanceSpec> InstanceSpecs
		{
			get
			{
				return instanceSpecs;
			}
			set	
			{
				instanceSpecs = value;
			}
		}

		public class DescribeInstanceSpecs_InstanceSpec
		{

			private string instanceId;

			private int? baseBandwidth;

			private int? elasticBandwidth;

			private int? portLimit;

			private int? siteLimit;

			private int? domainLimit;

			private int? bandwidthMbps;

			private int? defenseCount;

			private string functionVersion;

			private int? qpsLimit;

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

			public int? BaseBandwidth
			{
				get
				{
					return baseBandwidth;
				}
				set	
				{
					baseBandwidth = value;
				}
			}

			public int? ElasticBandwidth
			{
				get
				{
					return elasticBandwidth;
				}
				set	
				{
					elasticBandwidth = value;
				}
			}

			public int? PortLimit
			{
				get
				{
					return portLimit;
				}
				set	
				{
					portLimit = value;
				}
			}

			public int? SiteLimit
			{
				get
				{
					return siteLimit;
				}
				set	
				{
					siteLimit = value;
				}
			}

			public int? DomainLimit
			{
				get
				{
					return domainLimit;
				}
				set	
				{
					domainLimit = value;
				}
			}

			public int? BandwidthMbps
			{
				get
				{
					return bandwidthMbps;
				}
				set	
				{
					bandwidthMbps = value;
				}
			}

			public int? DefenseCount
			{
				get
				{
					return defenseCount;
				}
				set	
				{
					defenseCount = value;
				}
			}

			public string FunctionVersion
			{
				get
				{
					return functionVersion;
				}
				set	
				{
					functionVersion = value;
				}
			}

			public int? QpsLimit
			{
				get
				{
					return qpsLimit;
				}
				set	
				{
					qpsLimit = value;
				}
			}
		}
	}
}
