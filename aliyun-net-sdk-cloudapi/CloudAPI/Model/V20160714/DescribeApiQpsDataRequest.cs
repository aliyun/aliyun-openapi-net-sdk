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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CloudAPI.Transform;
using Aliyun.Acs.CloudAPI.Transform.V20160714;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
    public class DescribeApiQpsDataRequest : RpcAcsRequest<DescribeApiQpsDataResponse>
    {
        public DescribeApiQpsDataRequest()
            : base("CloudAPI", "2016-07-14", "DescribeApiQpsData", "apigateway", "openAPI")
        {
        }

		private string securityToken;

		private string groupId;

		private string endTime;

		private string startTime;

		private string apiId;

		private string accessKeyId;

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public string ApiId
		{
			get
			{
				return apiId;
			}
			set	
			{
				apiId = value;
				DictionaryUtil.Add(QueryParameters, "ApiId", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override DescribeApiQpsDataResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeApiQpsDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}