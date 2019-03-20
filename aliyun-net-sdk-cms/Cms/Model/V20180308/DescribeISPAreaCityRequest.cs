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
using Aliyun.Acs.Cms.Transform;
using Aliyun.Acs.Cms.Transform.V20180308;

namespace Aliyun.Acs.Cms.Model.V20180308
{
    public class DescribeISPAreaCityRequest : RpcAcsRequest<DescribeISPAreaCityResponse>
    {
        public DescribeISPAreaCityRequest()
            : base("Cms", "2018-03-08", "DescribeISPAreaCity", "cms", "openAPI")
        {
        }

		private string city;

		private string isp;

		public string City
		{
			get
			{
				return city;
			}
			set	
			{
				city = value;
				DictionaryUtil.Add(QueryParameters, "City", value);
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
				DictionaryUtil.Add(QueryParameters, "Isp", value);
			}
		}

        public override DescribeISPAreaCityResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeISPAreaCityResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
