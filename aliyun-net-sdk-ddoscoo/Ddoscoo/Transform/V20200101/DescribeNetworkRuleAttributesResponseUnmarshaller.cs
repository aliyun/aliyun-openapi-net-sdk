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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeNetworkRuleAttributesResponseUnmarshaller
    {
        public static DescribeNetworkRuleAttributesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNetworkRuleAttributesResponse describeNetworkRuleAttributesResponse = new DescribeNetworkRuleAttributesResponse();

			describeNetworkRuleAttributesResponse.HttpResponse = _ctx.HttpResponse;
			describeNetworkRuleAttributesResponse.RequestId = _ctx.StringValue("DescribeNetworkRuleAttributes.RequestId");

			List<DescribeNetworkRuleAttributesResponse.DescribeNetworkRuleAttributes_NetworkRuleAttribute> describeNetworkRuleAttributesResponse_networkRuleAttributes = new List<DescribeNetworkRuleAttributesResponse.DescribeNetworkRuleAttributes_NetworkRuleAttribute>();
			for (int i = 0; i < _ctx.Length("DescribeNetworkRuleAttributes.NetworkRuleAttributes.Length"); i++) {
				DescribeNetworkRuleAttributesResponse.DescribeNetworkRuleAttributes_NetworkRuleAttribute networkRuleAttribute = new DescribeNetworkRuleAttributesResponse.DescribeNetworkRuleAttributes_NetworkRuleAttribute();
				networkRuleAttribute.InstanceId = _ctx.StringValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].InstanceId");
				networkRuleAttribute.Protocol = _ctx.StringValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Protocol");
				networkRuleAttribute.FrontendPort = _ctx.IntegerValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].FrontendPort");

				DescribeNetworkRuleAttributesResponse.DescribeNetworkRuleAttributes_NetworkRuleAttribute.DescribeNetworkRuleAttributes_Config config = new DescribeNetworkRuleAttributesResponse.DescribeNetworkRuleAttributes_NetworkRuleAttribute.DescribeNetworkRuleAttributes_Config();
				config.PersistenceTimeout = _ctx.IntegerValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.PersistenceTimeout");
				config.Synproxy = _ctx.StringValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.Synproxy");
				config.NodataConn = _ctx.StringValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.NodataConn");

				DescribeNetworkRuleAttributesResponse.DescribeNetworkRuleAttributes_NetworkRuleAttribute.DescribeNetworkRuleAttributes_Config.DescribeNetworkRuleAttributes_Sla sla = new DescribeNetworkRuleAttributesResponse.DescribeNetworkRuleAttributes_NetworkRuleAttribute.DescribeNetworkRuleAttributes_Config.DescribeNetworkRuleAttributes_Sla();
				sla.Cps = _ctx.IntegerValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.Sla.Cps");
				sla.Maxconn = _ctx.IntegerValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.Sla.Maxconn");
				sla.CpsEnable = _ctx.IntegerValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.Sla.CpsEnable");
				sla.MaxconnEnable = _ctx.IntegerValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.Sla.MaxconnEnable");
				config.Sla = sla;

				DescribeNetworkRuleAttributesResponse.DescribeNetworkRuleAttributes_NetworkRuleAttribute.DescribeNetworkRuleAttributes_Config.DescribeNetworkRuleAttributes_Slimit slimit = new DescribeNetworkRuleAttributesResponse.DescribeNetworkRuleAttributes_NetworkRuleAttribute.DescribeNetworkRuleAttributes_Config.DescribeNetworkRuleAttributes_Slimit();
				slimit.Cps = _ctx.IntegerValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.Slimit.Cps");
				slimit.Maxconn = _ctx.IntegerValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.Slimit.Maxconn");
				slimit.CpsEnable = _ctx.IntegerValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.Slimit.CpsEnable");
				slimit.CpsMode = _ctx.IntegerValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.Slimit.CpsMode");
				slimit.MaxconnEnable = _ctx.IntegerValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.Slimit.MaxconnEnable");
				slimit.Bps = _ctx.LongValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.Slimit.Bps");
				slimit.Pps = _ctx.LongValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.Slimit.Pps");
				config.Slimit = slimit;

				DescribeNetworkRuleAttributesResponse.DescribeNetworkRuleAttributes_NetworkRuleAttribute.DescribeNetworkRuleAttributes_Config.DescribeNetworkRuleAttributes_PayloadLen payloadLen = new DescribeNetworkRuleAttributesResponse.DescribeNetworkRuleAttributes_NetworkRuleAttribute.DescribeNetworkRuleAttributes_Config.DescribeNetworkRuleAttributes_PayloadLen();
				payloadLen.Min = _ctx.IntegerValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.PayloadLen.Min");
				payloadLen.Max = _ctx.IntegerValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.PayloadLen.Max");
				config.PayloadLen = payloadLen;

				DescribeNetworkRuleAttributesResponse.DescribeNetworkRuleAttributes_NetworkRuleAttribute.DescribeNetworkRuleAttributes_Config.DescribeNetworkRuleAttributes_Cc cc = new DescribeNetworkRuleAttributesResponse.DescribeNetworkRuleAttributes_NetworkRuleAttribute.DescribeNetworkRuleAttributes_Config.DescribeNetworkRuleAttributes_Cc();

				List<DescribeNetworkRuleAttributesResponse.DescribeNetworkRuleAttributes_NetworkRuleAttribute.DescribeNetworkRuleAttributes_Config.DescribeNetworkRuleAttributes_Cc.DescribeNetworkRuleAttributes_SblackItem> cc_sblack = new List<DescribeNetworkRuleAttributesResponse.DescribeNetworkRuleAttributes_NetworkRuleAttribute.DescribeNetworkRuleAttributes_Config.DescribeNetworkRuleAttributes_Cc.DescribeNetworkRuleAttributes_SblackItem>();
				for (int j = 0; j < _ctx.Length("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.Cc.Sblack.Length"); j++) {
					DescribeNetworkRuleAttributesResponse.DescribeNetworkRuleAttributes_NetworkRuleAttribute.DescribeNetworkRuleAttributes_Config.DescribeNetworkRuleAttributes_Cc.DescribeNetworkRuleAttributes_SblackItem sblackItem = new DescribeNetworkRuleAttributesResponse.DescribeNetworkRuleAttributes_NetworkRuleAttribute.DescribeNetworkRuleAttributes_Config.DescribeNetworkRuleAttributes_Cc.DescribeNetworkRuleAttributes_SblackItem();
					sblackItem.During = _ctx.IntegerValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.Cc.Sblack["+ j +"].During");
					sblackItem.Expires = _ctx.IntegerValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.Cc.Sblack["+ j +"].Expires");
					sblackItem.Cnt = _ctx.IntegerValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.Cc.Sblack["+ j +"].Cnt");
					sblackItem.Type = _ctx.IntegerValue("DescribeNetworkRuleAttributes.NetworkRuleAttributes["+ i +"].Config.Cc.Sblack["+ j +"].Type");

					cc_sblack.Add(sblackItem);
				}
				cc.Sblack = cc_sblack;
				config.Cc = cc;
				networkRuleAttribute.Config = config;

				describeNetworkRuleAttributesResponse_networkRuleAttributes.Add(networkRuleAttribute);
			}
			describeNetworkRuleAttributesResponse.NetworkRuleAttributes = describeNetworkRuleAttributesResponse_networkRuleAttributes;
        
			return describeNetworkRuleAttributesResponse;
        }
    }
}
