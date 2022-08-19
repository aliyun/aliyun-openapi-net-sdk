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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeVpnGatewaysResponseUnmarshaller
    {
        public static DescribeVpnGatewaysResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVpnGatewaysResponse describeVpnGatewaysResponse = new DescribeVpnGatewaysResponse();

			describeVpnGatewaysResponse.HttpResponse = _ctx.HttpResponse;
			describeVpnGatewaysResponse.PageSize = _ctx.IntegerValue("DescribeVpnGateways.PageSize");
			describeVpnGatewaysResponse.RequestId = _ctx.StringValue("DescribeVpnGateways.RequestId");
			describeVpnGatewaysResponse.PageNumber = _ctx.IntegerValue("DescribeVpnGateways.PageNumber");
			describeVpnGatewaysResponse.TotalCount = _ctx.IntegerValue("DescribeVpnGateways.TotalCount");

			List<DescribeVpnGatewaysResponse.DescribeVpnGateways_VpnGateway> describeVpnGatewaysResponse_vpnGateways = new List<DescribeVpnGatewaysResponse.DescribeVpnGateways_VpnGateway>();
			for (int i = 0; i < _ctx.Length("DescribeVpnGateways.VpnGateways.Length"); i++) {
				DescribeVpnGatewaysResponse.DescribeVpnGateways_VpnGateway vpnGateway = new DescribeVpnGatewaysResponse.DescribeVpnGateways_VpnGateway();
				vpnGateway.VpnType = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].VpnType");
				vpnGateway.Status = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].Status");
				vpnGateway.VpcId = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].VpcId");
				vpnGateway.SslMaxConnections = _ctx.LongValue("DescribeVpnGateways.VpnGateways["+ i +"].SslMaxConnections");
				vpnGateway.Spec = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].Spec");
				vpnGateway.InternetIp = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].InternetIp");
				vpnGateway.CreateTime = _ctx.LongValue("DescribeVpnGateways.VpnGateways["+ i +"].CreateTime");
				vpnGateway.AutoPropagate = _ctx.BooleanValue("DescribeVpnGateways.VpnGateways["+ i +"].AutoPropagate");
				vpnGateway.ChargeType = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].ChargeType");
				vpnGateway.VpnGatewayId = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].VpnGatewayId");
				vpnGateway.Tag = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].Tag");
				vpnGateway.IpsecVpn = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].IpsecVpn");
				vpnGateway.EndTime = _ctx.LongValue("DescribeVpnGateways.VpnGateways["+ i +"].EndTime");
				vpnGateway.VSwitchId = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].VSwitchId");
				vpnGateway.Description = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].Description");
				vpnGateway.EnableBgp = _ctx.BooleanValue("DescribeVpnGateways.VpnGateways["+ i +"].EnableBgp");
				vpnGateway.BusinessStatus = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].BusinessStatus");
				vpnGateway.SslVpn = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].SslVpn");
				vpnGateway.Name = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].Name");
				vpnGateway.NetworkType = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].NetworkType");

				DescribeVpnGatewaysResponse.DescribeVpnGateways_VpnGateway.DescribeVpnGateways_ReservationData reservationData = new DescribeVpnGatewaysResponse.DescribeVpnGateways_VpnGateway.DescribeVpnGateways_ReservationData();
				reservationData.Status = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].ReservationData.Status");
				reservationData.ReservationOrderType = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].ReservationData.ReservationOrderType");
				reservationData.ReservationIpsec = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].ReservationData.ReservationIpsec");
				reservationData.ReservationSpec = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].ReservationData.ReservationSpec");
				reservationData.ReservationSsl = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].ReservationData.ReservationSsl");
				reservationData.ReservationMaxConnections = _ctx.IntegerValue("DescribeVpnGateways.VpnGateways["+ i +"].ReservationData.ReservationMaxConnections");
				reservationData.ReservationEndTime = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].ReservationData.ReservationEndTime");
				vpnGateway.ReservationData = reservationData;

				List<DescribeVpnGatewaysResponse.DescribeVpnGateways_VpnGateway.DescribeVpnGateways_Tag> vpnGateway_tags = new List<DescribeVpnGatewaysResponse.DescribeVpnGateways_VpnGateway.DescribeVpnGateways_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeVpnGateways.VpnGateways["+ i +"].Tags.Length"); j++) {
					DescribeVpnGatewaysResponse.DescribeVpnGateways_VpnGateway.DescribeVpnGateways_Tag tag = new DescribeVpnGatewaysResponse.DescribeVpnGateways_VpnGateway.DescribeVpnGateways_Tag();
					tag.Key = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].Tags["+ j +"].Value");

					vpnGateway_tags.Add(tag);
				}
				vpnGateway.Tags = vpnGateway_tags;

				describeVpnGatewaysResponse_vpnGateways.Add(vpnGateway);
			}
			describeVpnGatewaysResponse.VpnGateways = describeVpnGatewaysResponse_vpnGateways;
        
			return describeVpnGatewaysResponse;
        }
    }
}
