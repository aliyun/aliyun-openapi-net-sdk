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

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribeNetworkRuleAttributesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeNetworkRuleAttributes_NetworkRuleAttribute> networkRuleAttributes;

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

		public List<DescribeNetworkRuleAttributes_NetworkRuleAttribute> NetworkRuleAttributes
		{
			get
			{
				return networkRuleAttributes;
			}
			set	
			{
				networkRuleAttributes = value;
			}
		}

		public class DescribeNetworkRuleAttributes_NetworkRuleAttribute
		{

			private int? frontendPort;

			private string instanceId;

			private string protocol;

			private DescribeNetworkRuleAttributes_Config config;

			public int? FrontendPort
			{
				get
				{
					return frontendPort;
				}
				set	
				{
					frontendPort = value;
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

			public DescribeNetworkRuleAttributes_Config Config
			{
				get
				{
					return config;
				}
				set	
				{
					config = value;
				}
			}

			public class DescribeNetworkRuleAttributes_Config
			{

				private string nodataConn;

				private string synproxy;

				private int? persistenceTimeout;

				private DescribeNetworkRuleAttributes_Sla sla;

				private DescribeNetworkRuleAttributes_Slimit slimit;

				private DescribeNetworkRuleAttributes_PayloadLen payloadLen;

				private DescribeNetworkRuleAttributes_Cc cc;

				public string NodataConn
				{
					get
					{
						return nodataConn;
					}
					set	
					{
						nodataConn = value;
					}
				}

				public string Synproxy
				{
					get
					{
						return synproxy;
					}
					set	
					{
						synproxy = value;
					}
				}

				public int? PersistenceTimeout
				{
					get
					{
						return persistenceTimeout;
					}
					set	
					{
						persistenceTimeout = value;
					}
				}

				public DescribeNetworkRuleAttributes_Sla Sla
				{
					get
					{
						return sla;
					}
					set	
					{
						sla = value;
					}
				}

				public DescribeNetworkRuleAttributes_Slimit Slimit
				{
					get
					{
						return slimit;
					}
					set	
					{
						slimit = value;
					}
				}

				public DescribeNetworkRuleAttributes_PayloadLen PayloadLen
				{
					get
					{
						return payloadLen;
					}
					set	
					{
						payloadLen = value;
					}
				}

				public DescribeNetworkRuleAttributes_Cc Cc
				{
					get
					{
						return cc;
					}
					set	
					{
						cc = value;
					}
				}

				public class DescribeNetworkRuleAttributes_Sla
				{

					private int? maxconnEnable;

					private int? cpsEnable;

					private int? cps;

					private int? maxconn;

					public int? MaxconnEnable
					{
						get
						{
							return maxconnEnable;
						}
						set	
						{
							maxconnEnable = value;
						}
					}

					public int? CpsEnable
					{
						get
						{
							return cpsEnable;
						}
						set	
						{
							cpsEnable = value;
						}
					}

					public int? Cps
					{
						get
						{
							return cps;
						}
						set	
						{
							cps = value;
						}
					}

					public int? Maxconn
					{
						get
						{
							return maxconn;
						}
						set	
						{
							maxconn = value;
						}
					}
				}

				public class DescribeNetworkRuleAttributes_Slimit
				{

					private int? maxconnEnable;

					private int? cpsEnable;

					private int? cps;

					private long? pps;

					private long? bps;

					private int? maxconn;

					private int? cpsMode;

					public int? MaxconnEnable
					{
						get
						{
							return maxconnEnable;
						}
						set	
						{
							maxconnEnable = value;
						}
					}

					public int? CpsEnable
					{
						get
						{
							return cpsEnable;
						}
						set	
						{
							cpsEnable = value;
						}
					}

					public int? Cps
					{
						get
						{
							return cps;
						}
						set	
						{
							cps = value;
						}
					}

					public long? Pps
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

					public long? Bps
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

					public int? Maxconn
					{
						get
						{
							return maxconn;
						}
						set	
						{
							maxconn = value;
						}
					}

					public int? CpsMode
					{
						get
						{
							return cpsMode;
						}
						set	
						{
							cpsMode = value;
						}
					}
				}

				public class DescribeNetworkRuleAttributes_PayloadLen
				{

					private int? min;

					private int? max;

					public int? Min
					{
						get
						{
							return min;
						}
						set	
						{
							min = value;
						}
					}

					public int? Max
					{
						get
						{
							return max;
						}
						set	
						{
							max = value;
						}
					}
				}

				public class DescribeNetworkRuleAttributes_Cc
				{

					private List<DescribeNetworkRuleAttributes_SblackItem> sblack;

					public List<DescribeNetworkRuleAttributes_SblackItem> Sblack
					{
						get
						{
							return sblack;
						}
						set	
						{
							sblack = value;
						}
					}

					public class DescribeNetworkRuleAttributes_SblackItem
					{

						private int? type;

						private int? during;

						private int? expires;

						private int? cnt;

						public int? Type
						{
							get
							{
								return type;
							}
							set	
							{
								type = value;
							}
						}

						public int? During
						{
							get
							{
								return during;
							}
							set	
							{
								during = value;
							}
						}

						public int? Expires
						{
							get
							{
								return expires;
							}
							set	
							{
								expires = value;
							}
						}

						public int? Cnt
						{
							get
							{
								return cnt;
							}
							set	
							{
								cnt = value;
							}
						}
					}
				}
			}
		}
	}
}
