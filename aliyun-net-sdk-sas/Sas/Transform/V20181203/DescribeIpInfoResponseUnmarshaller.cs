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
        public static DescribeIpInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeIpInfoResponse describeIpInfoResponse = new DescribeIpInfoResponse();

			describeIpInfoResponse.HttpResponse = context.HttpResponse;
			describeIpInfoResponse.RequestId = context.StringValue("DescribeIpInfo.RequestId");
			describeIpInfoResponse.Ip = context.StringValue("DescribeIpInfo.ip");
			describeIpInfoResponse.Geo = context.StringValue("DescribeIpInfo.geo");
			describeIpInfoResponse.Is_proxy = context.StringValue("DescribeIpInfo.is_proxy");
			describeIpInfoResponse.Gmt_last_tor = context.StringValue("DescribeIpInfo.gmt_last_tor");
			describeIpInfoResponse.Tor_day_trace = context.StringValue("DescribeIpInfo.tor_day_trace");
			describeIpInfoResponse.Total_day_cnt_tor = context.StringValue("DescribeIpInfo.total_day_cnt_tor");
			describeIpInfoResponse.Day_cnt_7d_tor = context.StringValue("DescribeIpInfo.day_cnt_7d_tor");
			describeIpInfoResponse.Day_cnt_30d_tor = context.StringValue("DescribeIpInfo.day_cnt_30d_tor");
			describeIpInfoResponse.Is_tor = context.StringValue("DescribeIpInfo.is_tor");
			describeIpInfoResponse.Gmt_last_web_attack = context.StringValue("DescribeIpInfo.gmt_last_web_attack");
			describeIpInfoResponse.Web_attack_day_trace = context.StringValue("DescribeIpInfo.web_attack_day_trace");
			describeIpInfoResponse.Total_day_cnt_web_attack = context.StringValue("DescribeIpInfo.total_day_cnt_web_attack");
			describeIpInfoResponse.Day_cnt_7d_web_attack = context.StringValue("DescribeIpInfo.day_cnt_7d_web_attack");
			describeIpInfoResponse.Day_cnt_30d_web_attack = context.StringValue("DescribeIpInfo.day_cnt_30d_web_attack");
			describeIpInfoResponse.Is_web_attack = context.StringValue("DescribeIpInfo.is_web_attack");
			describeIpInfoResponse.Gmt_last_proxy = context.StringValue("DescribeIpInfo.gmt_last_proxy");
			describeIpInfoResponse.Proxy_day_trace = context.StringValue("DescribeIpInfo.proxy_day_trace");
			describeIpInfoResponse.Is_proxy_1d = context.StringValue("DescribeIpInfo.is_proxy_1d");
			describeIpInfoResponse.Is_proxy_7d = context.StringValue("DescribeIpInfo.is_proxy_7d");
			describeIpInfoResponse.Is_tor_1d = context.StringValue("DescribeIpInfo.is_tor_1d");
			describeIpInfoResponse.Is_tor_7d = context.StringValue("DescribeIpInfo.is_tor_7d");
			describeIpInfoResponse.Is_web_attack_1d = context.StringValue("DescribeIpInfo.is_web_attack_1d");
			describeIpInfoResponse.Is_web_attack_7d = context.StringValue("DescribeIpInfo.is_web_attack_7d");
			describeIpInfoResponse.Is_web_attack_30d = context.StringValue("DescribeIpInfo.is_web_attack_30d");
			describeIpInfoResponse.Province = context.StringValue("DescribeIpInfo.province");
			describeIpInfoResponse.City = context.StringValue("DescribeIpInfo.city");
			describeIpInfoResponse.Isp = context.StringValue("DescribeIpInfo.isp");
			describeIpInfoResponse.Country = context.StringValue("DescribeIpInfo.country");
			describeIpInfoResponse.Gmt_last_nat = context.StringValue("DescribeIpInfo.gmt_last_nat");
			describeIpInfoResponse.Nat_day_trace = context.StringValue("DescribeIpInfo.nat_day_trace");
			describeIpInfoResponse.Is_nat = context.StringValue("DescribeIpInfo.is_nat");
			describeIpInfoResponse.Is_nat_1d = context.StringValue("DescribeIpInfo.is_nat_1d");
			describeIpInfoResponse.Is_nat_7d = context.StringValue("DescribeIpInfo.is_nat_7d");
			describeIpInfoResponse.Gmt_first_mining_pool = context.StringValue("DescribeIpInfo.gmt_first_mining_pool");
			describeIpInfoResponse.Gmt_last_mining_pool = context.StringValue("DescribeIpInfo.gmt_last_mining_pool");
			describeIpInfoResponse.Mining_pool_day_trace = context.StringValue("DescribeIpInfo.mining_pool_day_trace");
			describeIpInfoResponse.Is_mining_pool = context.StringValue("DescribeIpInfo.is_mining_pool");
			describeIpInfoResponse.Is_mining_pool_1d = context.StringValue("DescribeIpInfo.is_mining_pool_1d");
			describeIpInfoResponse.Is_mining_pool_7d = context.StringValue("DescribeIpInfo.is_mining_pool_7d");
			describeIpInfoResponse.Gmt_first_c2 = context.StringValue("DescribeIpInfo.gmt_first_c2");
			describeIpInfoResponse.Gmt_last_c2 = context.StringValue("DescribeIpInfo.gmt_last_c2");
			describeIpInfoResponse.C2_day_trace = context.StringValue("DescribeIpInfo.c2_day_trace");
			describeIpInfoResponse.Is_c2 = context.StringValue("DescribeIpInfo.is_c2");
			describeIpInfoResponse.Is_c2_1d = context.StringValue("DescribeIpInfo.is_c2_1d");
			describeIpInfoResponse.Is_c2_7d = context.StringValue("DescribeIpInfo.is_c2_7d");
			describeIpInfoResponse.Gmt_last_malicious_source = context.StringValue("DescribeIpInfo.gmt_last_malicious_source");
			describeIpInfoResponse.Malicious_source_day_trace = context.StringValue("DescribeIpInfo.malicious_source_day_trace");
			describeIpInfoResponse.Is_malicious_source = context.StringValue("DescribeIpInfo.is_malicious_source");
			describeIpInfoResponse.Is_malicious_source_1d = context.StringValue("DescribeIpInfo.is_malicious_source_1d");
			describeIpInfoResponse.Is_malicious_source_7d = context.StringValue("DescribeIpInfo.is_malicious_source_7d");
			describeIpInfoResponse.Is_malicious_source_30d = context.StringValue("DescribeIpInfo.is_malicious_source_30d");
			describeIpInfoResponse.Is_idc = context.StringValue("DescribeIpInfo.is_idc");
			describeIpInfoResponse.Idc_name = context.StringValue("DescribeIpInfo.idc_name");
			describeIpInfoResponse.Is_malicious_login = context.StringValue("DescribeIpInfo.is_malicious_login");
			describeIpInfoResponse.Gmt_last_malicious_login = context.StringValue("DescribeIpInfo.gmt_last_malicious_login");
			describeIpInfoResponse.Malicious_login_day_trace = context.StringValue("DescribeIpInfo.malicious_login_day_trace");
			describeIpInfoResponse.Is_malicious_login_1d = context.StringValue("DescribeIpInfo.is_malicious_login_1d");
			describeIpInfoResponse.Is_malicious_login_7d = context.StringValue("DescribeIpInfo.is_malicious_login_7d");
			describeIpInfoResponse.Malicious_score = context.StringValue("DescribeIpInfo.malicious_score");
			describeIpInfoResponse.Tags = context.StringValue("DescribeIpInfo.tags");
			describeIpInfoResponse.Rdns = context.StringValue("DescribeIpInfo.rdns");
        
			return describeIpInfoResponse;
        }
    }
}
