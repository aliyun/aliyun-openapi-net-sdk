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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeVpnGatewayResponse : AcsResponse
	{

		private string vpnType;

		private string status;

		private string vpcId;

		private long? sslMaxConnections;

		private string spec;

		private string internetIp;

		private long? createTime;

		private bool? autoPropagate;

		private string chargeType;

		private string vpnGatewayId;

		private string tag;

		private string ipsecVpn;

		private long? endTime;

		private string vSwitchId;

		private string requestId;

		private string description;

		private bool? enableBgp;

		private string businessStatus;

		private string sslVpn;

		private string name;

		private List<DescribeVpnGateway_Tag> tags;

		private DescribeVpnGateway_ReservationData reservationData;

		public string VpnType
		{
			get
			{
				return vpnType;
			}
			set	
			{
				vpnType = value;
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

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
			}
		}

		public long? SslMaxConnections
		{
			get
			{
				return sslMaxConnections;
			}
			set	
			{
				sslMaxConnections = value;
			}
		}

		public string Spec
		{
			get
			{
				return spec;
			}
			set	
			{
				spec = value;
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

		public long? CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		public bool? AutoPropagate
		{
			get
			{
				return autoPropagate;
			}
			set	
			{
				autoPropagate = value;
			}
		}

		public string ChargeType
		{
			get
			{
				return chargeType;
			}
			set	
			{
				chargeType = value;
			}
		}

		public string VpnGatewayId
		{
			get
			{
				return vpnGatewayId;
			}
			set	
			{
				vpnGatewayId = value;
			}
		}

		public string Tag
		{
			get
			{
				return tag;
			}
			set	
			{
				tag = value;
			}
		}

		public string IpsecVpn
		{
			get
			{
				return ipsecVpn;
			}
			set	
			{
				ipsecVpn = value;
			}
		}

		public long? EndTime
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

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
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

		public bool? EnableBgp
		{
			get
			{
				return enableBgp;
			}
			set	
			{
				enableBgp = value;
			}
		}

		public string BusinessStatus
		{
			get
			{
				return businessStatus;
			}
			set	
			{
				businessStatus = value;
			}
		}

		public string SslVpn
		{
			get
			{
				return sslVpn;
			}
			set	
			{
				sslVpn = value;
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

		public List<DescribeVpnGateway_Tag> Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
			}
		}

		public DescribeVpnGateway_ReservationData ReservationData
		{
			get
			{
				return reservationData;
			}
			set	
			{
				reservationData = value;
			}
		}

		public class DescribeVpnGateway_Tag
		{

			private string key;

			private string _value;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class DescribeVpnGateway_ReservationData
		{

			private string status;

			private string reservationOrderType;

			private string reservationIpsec;

			private string reservationSpec;

			private string reservationSsl;

			private int? reservationMaxConnections;

			private string reservationEndTime;

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

			public string ReservationOrderType
			{
				get
				{
					return reservationOrderType;
				}
				set	
				{
					reservationOrderType = value;
				}
			}

			public string ReservationIpsec
			{
				get
				{
					return reservationIpsec;
				}
				set	
				{
					reservationIpsec = value;
				}
			}

			public string ReservationSpec
			{
				get
				{
					return reservationSpec;
				}
				set	
				{
					reservationSpec = value;
				}
			}

			public string ReservationSsl
			{
				get
				{
					return reservationSsl;
				}
				set	
				{
					reservationSsl = value;
				}
			}

			public int? ReservationMaxConnections
			{
				get
				{
					return reservationMaxConnections;
				}
				set	
				{
					reservationMaxConnections = value;
				}
			}

			public string ReservationEndTime
			{
				get
				{
					return reservationEndTime;
				}
				set	
				{
					reservationEndTime = value;
				}
			}
		}
	}
}
