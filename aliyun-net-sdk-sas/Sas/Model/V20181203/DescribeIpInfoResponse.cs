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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeIpInfoResponse : AcsResponse
	{

		private string requestId;

		private string ip;

		private string geo;

		private string is_proxy;

		private string gmt_last_tor;

		private string tor_day_trace;

		private string total_day_cnt_tor;

		private string day_cnt_7d_tor;

		private string day_cnt_30d_tor;

		private string is_tor;

		private string gmt_last_web_attack;

		private string web_attack_day_trace;

		private string total_day_cnt_web_attack;

		private string day_cnt_7d_web_attack;

		private string day_cnt_30d_web_attack;

		private string is_web_attack;

		private string gmt_last_proxy;

		private string proxy_day_trace;

		private string is_proxy_1d;

		private string is_proxy_7d;

		private string is_tor_1d;

		private string is_tor_7d;

		private string is_web_attack_1d;

		private string is_web_attack_7d;

		private string is_web_attack_30d;

		private string province;

		private string city;

		private string isp;

		private string country;

		private string gmt_last_nat;

		private string nat_day_trace;

		private string is_nat;

		private string is_nat_1d;

		private string is_nat_7d;

		private string gmt_first_mining_pool;

		private string gmt_last_mining_pool;

		private string mining_pool_day_trace;

		private string is_mining_pool;

		private string is_mining_pool_1d;

		private string is_mining_pool_7d;

		private string gmt_first_c2;

		private string gmt_last_c2;

		private string c2_day_trace;

		private string is_c2;

		private string is_c2_1d;

		private string is_c2_7d;

		private string gmt_last_malicious_source;

		private string malicious_source_day_trace;

		private string is_malicious_source;

		private string is_malicious_source_1d;

		private string is_malicious_source_7d;

		private string is_malicious_source_30d;

		private string is_idc;

		private string idc_name;

		private string is_malicious_login;

		private string gmt_last_malicious_login;

		private string malicious_login_day_trace;

		private string is_malicious_login_1d;

		private string is_malicious_login_7d;

		private string malicious_score;

		private string tags;

		private string rdns;

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

		public string Ip
		{
			get
			{
				return ip;
			}
			set	
			{
				ip = value;
			}
		}

		public string Geo
		{
			get
			{
				return geo;
			}
			set	
			{
				geo = value;
			}
		}

		public string Is_proxy
		{
			get
			{
				return is_proxy;
			}
			set	
			{
				is_proxy = value;
			}
		}

		public string Gmt_last_tor
		{
			get
			{
				return gmt_last_tor;
			}
			set	
			{
				gmt_last_tor = value;
			}
		}

		public string Tor_day_trace
		{
			get
			{
				return tor_day_trace;
			}
			set	
			{
				tor_day_trace = value;
			}
		}

		public string Total_day_cnt_tor
		{
			get
			{
				return total_day_cnt_tor;
			}
			set	
			{
				total_day_cnt_tor = value;
			}
		}

		public string Day_cnt_7d_tor
		{
			get
			{
				return day_cnt_7d_tor;
			}
			set	
			{
				day_cnt_7d_tor = value;
			}
		}

		public string Day_cnt_30d_tor
		{
			get
			{
				return day_cnt_30d_tor;
			}
			set	
			{
				day_cnt_30d_tor = value;
			}
		}

		public string Is_tor
		{
			get
			{
				return is_tor;
			}
			set	
			{
				is_tor = value;
			}
		}

		public string Gmt_last_web_attack
		{
			get
			{
				return gmt_last_web_attack;
			}
			set	
			{
				gmt_last_web_attack = value;
			}
		}

		public string Web_attack_day_trace
		{
			get
			{
				return web_attack_day_trace;
			}
			set	
			{
				web_attack_day_trace = value;
			}
		}

		public string Total_day_cnt_web_attack
		{
			get
			{
				return total_day_cnt_web_attack;
			}
			set	
			{
				total_day_cnt_web_attack = value;
			}
		}

		public string Day_cnt_7d_web_attack
		{
			get
			{
				return day_cnt_7d_web_attack;
			}
			set	
			{
				day_cnt_7d_web_attack = value;
			}
		}

		public string Day_cnt_30d_web_attack
		{
			get
			{
				return day_cnt_30d_web_attack;
			}
			set	
			{
				day_cnt_30d_web_attack = value;
			}
		}

		public string Is_web_attack
		{
			get
			{
				return is_web_attack;
			}
			set	
			{
				is_web_attack = value;
			}
		}

		public string Gmt_last_proxy
		{
			get
			{
				return gmt_last_proxy;
			}
			set	
			{
				gmt_last_proxy = value;
			}
		}

		public string Proxy_day_trace
		{
			get
			{
				return proxy_day_trace;
			}
			set	
			{
				proxy_day_trace = value;
			}
		}

		public string Is_proxy_1d
		{
			get
			{
				return is_proxy_1d;
			}
			set	
			{
				is_proxy_1d = value;
			}
		}

		public string Is_proxy_7d
		{
			get
			{
				return is_proxy_7d;
			}
			set	
			{
				is_proxy_7d = value;
			}
		}

		public string Is_tor_1d
		{
			get
			{
				return is_tor_1d;
			}
			set	
			{
				is_tor_1d = value;
			}
		}

		public string Is_tor_7d
		{
			get
			{
				return is_tor_7d;
			}
			set	
			{
				is_tor_7d = value;
			}
		}

		public string Is_web_attack_1d
		{
			get
			{
				return is_web_attack_1d;
			}
			set	
			{
				is_web_attack_1d = value;
			}
		}

		public string Is_web_attack_7d
		{
			get
			{
				return is_web_attack_7d;
			}
			set	
			{
				is_web_attack_7d = value;
			}
		}

		public string Is_web_attack_30d
		{
			get
			{
				return is_web_attack_30d;
			}
			set	
			{
				is_web_attack_30d = value;
			}
		}

		public string Province
		{
			get
			{
				return province;
			}
			set	
			{
				province = value;
			}
		}

		public string City
		{
			get
			{
				return city;
			}
			set	
			{
				city = value;
			}
		}

		public string Isp
		{
			get
			{
				return isp;
			}
			set	
			{
				isp = value;
			}
		}

		public string Country
		{
			get
			{
				return country;
			}
			set	
			{
				country = value;
			}
		}

		public string Gmt_last_nat
		{
			get
			{
				return gmt_last_nat;
			}
			set	
			{
				gmt_last_nat = value;
			}
		}

		public string Nat_day_trace
		{
			get
			{
				return nat_day_trace;
			}
			set	
			{
				nat_day_trace = value;
			}
		}

		public string Is_nat
		{
			get
			{
				return is_nat;
			}
			set	
			{
				is_nat = value;
			}
		}

		public string Is_nat_1d
		{
			get
			{
				return is_nat_1d;
			}
			set	
			{
				is_nat_1d = value;
			}
		}

		public string Is_nat_7d
		{
			get
			{
				return is_nat_7d;
			}
			set	
			{
				is_nat_7d = value;
			}
		}

		public string Gmt_first_mining_pool
		{
			get
			{
				return gmt_first_mining_pool;
			}
			set	
			{
				gmt_first_mining_pool = value;
			}
		}

		public string Gmt_last_mining_pool
		{
			get
			{
				return gmt_last_mining_pool;
			}
			set	
			{
				gmt_last_mining_pool = value;
			}
		}

		public string Mining_pool_day_trace
		{
			get
			{
				return mining_pool_day_trace;
			}
			set	
			{
				mining_pool_day_trace = value;
			}
		}

		public string Is_mining_pool
		{
			get
			{
				return is_mining_pool;
			}
			set	
			{
				is_mining_pool = value;
			}
		}

		public string Is_mining_pool_1d
		{
			get
			{
				return is_mining_pool_1d;
			}
			set	
			{
				is_mining_pool_1d = value;
			}
		}

		public string Is_mining_pool_7d
		{
			get
			{
				return is_mining_pool_7d;
			}
			set	
			{
				is_mining_pool_7d = value;
			}
		}

		public string Gmt_first_c2
		{
			get
			{
				return gmt_first_c2;
			}
			set	
			{
				gmt_first_c2 = value;
			}
		}

		public string Gmt_last_c2
		{
			get
			{
				return gmt_last_c2;
			}
			set	
			{
				gmt_last_c2 = value;
			}
		}

		public string C2_day_trace
		{
			get
			{
				return c2_day_trace;
			}
			set	
			{
				c2_day_trace = value;
			}
		}

		public string Is_c2
		{
			get
			{
				return is_c2;
			}
			set	
			{
				is_c2 = value;
			}
		}

		public string Is_c2_1d
		{
			get
			{
				return is_c2_1d;
			}
			set	
			{
				is_c2_1d = value;
			}
		}

		public string Is_c2_7d
		{
			get
			{
				return is_c2_7d;
			}
			set	
			{
				is_c2_7d = value;
			}
		}

		public string Gmt_last_malicious_source
		{
			get
			{
				return gmt_last_malicious_source;
			}
			set	
			{
				gmt_last_malicious_source = value;
			}
		}

		public string Malicious_source_day_trace
		{
			get
			{
				return malicious_source_day_trace;
			}
			set	
			{
				malicious_source_day_trace = value;
			}
		}

		public string Is_malicious_source
		{
			get
			{
				return is_malicious_source;
			}
			set	
			{
				is_malicious_source = value;
			}
		}

		public string Is_malicious_source_1d
		{
			get
			{
				return is_malicious_source_1d;
			}
			set	
			{
				is_malicious_source_1d = value;
			}
		}

		public string Is_malicious_source_7d
		{
			get
			{
				return is_malicious_source_7d;
			}
			set	
			{
				is_malicious_source_7d = value;
			}
		}

		public string Is_malicious_source_30d
		{
			get
			{
				return is_malicious_source_30d;
			}
			set	
			{
				is_malicious_source_30d = value;
			}
		}

		public string Is_idc
		{
			get
			{
				return is_idc;
			}
			set	
			{
				is_idc = value;
			}
		}

		public string Idc_name
		{
			get
			{
				return idc_name;
			}
			set	
			{
				idc_name = value;
			}
		}

		public string Is_malicious_login
		{
			get
			{
				return is_malicious_login;
			}
			set	
			{
				is_malicious_login = value;
			}
		}

		public string Gmt_last_malicious_login
		{
			get
			{
				return gmt_last_malicious_login;
			}
			set	
			{
				gmt_last_malicious_login = value;
			}
		}

		public string Malicious_login_day_trace
		{
			get
			{
				return malicious_login_day_trace;
			}
			set	
			{
				malicious_login_day_trace = value;
			}
		}

		public string Is_malicious_login_1d
		{
			get
			{
				return is_malicious_login_1d;
			}
			set	
			{
				is_malicious_login_1d = value;
			}
		}

		public string Is_malicious_login_7d
		{
			get
			{
				return is_malicious_login_7d;
			}
			set	
			{
				is_malicious_login_7d = value;
			}
		}

		public string Malicious_score
		{
			get
			{
				return malicious_score;
			}
			set	
			{
				malicious_score = value;
			}
		}

		public string Tags
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

		public string Rdns
		{
			get
			{
				return rdns;
			}
			set	
			{
				rdns = value;
			}
		}
	}
}
