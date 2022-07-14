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

namespace Aliyun.Acs.antiddos_public.Model.V20170518
{
	public class DescribeDdosThresholdResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDdosThreshold_Threshold> thresholds;

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

		public List<DescribeDdosThreshold_Threshold> Thresholds
		{
			get
			{
				return thresholds;
			}
			set	
			{
				thresholds = value;
			}
		}

		public class DescribeDdosThreshold_Threshold
		{

			private string ddosType;

			private bool? isAuto;

			private int? maxBps;

			private int? elasticBps;

			private string instanceId;

			private int? bps;

			private int? pps;

			private int? maxPps;

			private string internetIp;

			public string DdosType
			{
				get
				{
					return ddosType;
				}
				set	
				{
					ddosType = value;
				}
			}

			public bool? IsAuto
			{
				get
				{
					return isAuto;
				}
				set	
				{
					isAuto = value;
				}
			}

			public int? MaxBps
			{
				get
				{
					return maxBps;
				}
				set	
				{
					maxBps = value;
				}
			}

			public int? ElasticBps
			{
				get
				{
					return elasticBps;
				}
				set	
				{
					elasticBps = value;
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

			public int? Bps
			{
				get
				{
					return bps;
				}
				set	
				{
					bps = value;
				}
			}

			public int? Pps
			{
				get
				{
					return pps;
				}
				set	
				{
					pps = value;
				}
			}

			public int? MaxPps
			{
				get
				{
					return maxPps;
				}
				set	
				{
					maxPps = value;
				}
			}

			public string InternetIp
			{
				get
				{
					return internetIp;
				}
				set	
				{
					internetIp = value;
				}
			}
		}
	}
}
