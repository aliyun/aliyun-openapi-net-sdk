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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeIpInfoResponseUnmarshaller
    {
        public static DescribeIpInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeIpInfoResponse describeIpInfoResponse = new DescribeIpInfoResponse();

			describeIpInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeIpInfoResponse.RequestId = _ctx.StringValue("DescribeIpInfo.RequestId");
			describeIpInfoResponse.Ip = _ctx.StringValue("DescribeIpInfo.ip");
			describeIpInfoResponse.Geo = _ctx.StringValue("DescribeIpInfo.geo");
			describeIpInfoResponse.Is_proxy = _ctx.StringValue("DescribeIpInfo.is_proxy");
			describeIpInfoResponse.Gmt_last_tor = _ctx.StringValue("DescribeIpInfo.gmt_last_tor");
			describeIpInfoResponse.Tor_day_trace = _ctx.StringValue("DescribeIpInfo.tor_day_trace");
			describeIpInfoResponse.Total_day_cnt_tor = _ctx.StringValue("DescribeIpInfo.total_day_cnt_tor");
			describeIpInfoResponse.Day_cnt_7d_tor = _ctx.StringValue("DescribeIpInfo.day_cnt_7d_tor");
			describeIpInfoResponse.Day_cnt_30d_tor = _ctx.StringValue("DescribeIpInfo.day_cnt_30d_tor");
			describeIpInfoResponse.Is_tor = _ctx.StringValue("DescribeIpInfo.is_tor");
			describeIpInfoResponse.Gmt_last_web_attack = _ctx.StringValue("DescribeIpInfo.gmt_last_web_attack");
			describeIpInfoResponse.Web_attack_day_trace = _ctx.StringValue("DescribeIpInfo.web_attack_day_trace");
			describeIpInfoResponse.Total_day_cnt_web_attack = _ctx.StringValue("DescribeIpInfo.total_day_cnt_web_attack");
			describeIpInfoResponse.Day_cnt_7d_web_attack = _ctx.StringValue("DescribeIpInfo.day_cnt_7d_web_attack");
			describeIpInfoResponse.Day_cnt_30d_web_attack = _ctx.StringValue("DescribeIpInfo.day_cnt_30d_web_attack");
			describeIpInfoResponse.Is_web_attack = _ctx.StringValue("DescribeIpInfo.is_web_attack");
			describeIpInfoResponse.Gmt_last_proxy = _ctx.StringValue("DescribeIpInfo.gmt_last_proxy");
			describeIpInfoResponse.Proxy_day_trace = _ctx.StringValue("DescribeIpInfo.proxy_day_trace");
			describeIpInfoResponse.Is_proxy_1d = _ctx.StringValue("DescribeIpInfo.is_proxy_1d");
			describeIpInfoResponse.Is_proxy_7d = _ctx.StringValue("DescribeIpInfo.is_proxy_7d");
			describeIpInfoResponse.Is_tor_1d = _ctx.StringValue("DescribeIpInfo.is_tor_1d");
			describeIpInfoResponse.Is_tor_7d = _ctx.StringValue("DescribeIpInfo.is_tor_7d");
			describeIpInfoResponse.Is_web_attack_1d = _ctx.StringValue("DescribeIpInfo.is_web_attack_1d");
			describeIpInfoResponse.Is_web_attack_7d = _ctx.StringValue("DescribeIpInfo.is_web_attack_7d");
			describeIpInfoResponse.Is_web_attack_30d = _ctx.StringValue("DescribeIpInfo.is_web_attack_30d");
			describeIpInfoResponse.Province = _ctx.StringValue("DescribeIpInfo.province");
			describeIpInfoResponse.City = _ctx.StringValue("DescribeIpInfo.city");
			describeIpInfoResponse.Isp = _ctx.StringValue("DescribeIpInfo.isp");
			describeIpInfoResponse.Country = _ctx.StringValue("DescribeIpInfo.country");
			describeIpInfoResponse.Gmt_last_nat = _ctx.StringValue("DescribeIpInfo.gmt_last_nat");
			describeIpInfoResponse.Nat_day_trace = _ctx.StringValue("DescribeIpInfo.nat_day_trace");
			describeIpInfoResponse.Is_nat = _ctx.StringValue("DescribeIpInfo.is_nat");
			describeIpInfoResponse.Is_nat_1d = _ctx.StringValue("DescribeIpInfo.is_nat_1d");
			describeIpInfoResponse.Is_nat_7d = _ctx.StringValue("DescribeIpInfo.is_nat_7d");
			describeIpInfoResponse.Gmt_first_mining_pool = _ctx.StringValue("DescribeIpInfo.gmt_first_mining_pool");
			describeIpInfoResponse.Gmt_last_mining_pool = _ctx.StringValue("DescribeIpInfo.gmt_last_mining_pool");
			describeIpInfoResponse.Mining_pool_day_trace = _ctx.StringValue("DescribeIpInfo.mining_pool_day_trace");
			describeIpInfoResponse.Is_mining_pool = _ctx.StringValue("DescribeIpInfo.is_mining_pool");
			describeIpInfoResponse.Is_mining_pool_1d = _ctx.StringValue("DescribeIpInfo.is_mining_pool_1d");
			describeIpInfoResponse.Is_mining_pool_7d = _ctx.StringValue("DescribeIpInfo.is_mining_pool_7d");
			describeIpInfoResponse.Gmt_first_c2 = _ctx.StringValue("DescribeIpInfo.gmt_first_c2");
			describeIpInfoResponse.Gmt_last_c2 = _ctx.StringValue("DescribeIpInfo.gmt_last_c2");
			describeIpInfoResponse.C2_day_trace = _ctx.StringValue("DescribeIpInfo.c2_day_trace");
			describeIpInfoResponse.Is_c2 = _ctx.StringValue("DescribeIpInfo.is_c2");
			describeIpInfoResponse.Is_c2_1d = _ctx.StringValue("DescribeIpInfo.is_c2_1d");
			describeIpInfoResponse.Is_c2_7d = _ctx.StringValue("DescribeIpInfo.is_c2_7d");
			describeIpInfoResponse.Gmt_last_malicious_source = _ctx.StringValue("DescribeIpInfo.gmt_last_malicious_source");
			describeIpInfoResponse.Malicious_source_day_trace = _ctx.StringValue("DescribeIpInfo.malicious_source_day_trace");
			describeIpInfoResponse.Is_malicious_source = _ctx.StringValue("DescribeIpInfo.is_malicious_source");
			describeIpInfoResponse.Is_malicious_source_1d = _ctx.StringValue("DescribeIpInfo.is_malicious_source_1d");
			describeIpInfoResponse.Is_malicious_source_7d = _ctx.StringValue("DescribeIpInfo.is_malicious_source_7d");
			describeIpInfoResponse.Is_malicious_source_30d = _ctx.StringValue("DescribeIpInfo.is_malicious_source_30d");
			describeIpInfoResponse.Is_idc = _ctx.StringValue("DescribeIpInfo.is_idc");
			describeIpInfoResponse.Idc_name = _ctx.StringValue("DescribeIpInfo.idc_name");
			describeIpInfoResponse.Is_malicious_login = _ctx.StringValue("DescribeIpInfo.is_malicious_login");
			describeIpInfoResponse.Gmt_last_malicious_login = _ctx.StringValue("DescribeIpInfo.gmt_last_malicious_login");
			describeIpInfoResponse.Malicious_login_day_trace = _ctx.StringValue("DescribeIpInfo.malicious_login_day_trace");
			describeIpInfoResponse.Is_malicious_login_1d = _ctx.StringValue("DescribeIpInfo.is_malicious_login_1d");
			describeIpInfoResponse.Is_malicious_login_7d = _ctx.StringValue("DescribeIpInfo.is_malicious_login_7d");
			describeIpInfoResponse.Malicious_score = _ctx.StringValue("DescribeIpInfo.malicious_score");
			describeIpInfoResponse.Tags = _ctx.StringValue("DescribeIpInfo.tags");
			describeIpInfoResponse.Rdns = _ctx.StringValue("DescribeIpInfo.rdns");
        
			return describeIpInfoResponse;
        }
    }
}
