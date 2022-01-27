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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.geoip.Transform;
using Aliyun.Acs.geoip.Transform.V20200101;

namespace Aliyun.Acs.geoip.Model.V20200101
{
    public class DescribeIpv6LocationRequest : RpcAcsRequest<DescribeIpv6LocationResponse>
    {
        public DescribeIpv6LocationRequest()
            : base("geoip", "2020-01-01", "DescribeIpv6Location", "geoip", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string ip;

		private string lang;

		public string Ip
		{
			get
			{
				return ip;
			}
			set	
			{
				ip = value;
				DictionaryUtil.Add(QueryParameters, "Ip", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

        public override DescribeIpv6LocationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeIpv6LocationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
