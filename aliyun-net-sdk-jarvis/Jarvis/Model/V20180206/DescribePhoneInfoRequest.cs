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
using Aliyun.Acs.jarvis.Transform;
using Aliyun.Acs.jarvis.Transform.V20180206;

namespace Aliyun.Acs.jarvis.Model.V20180206
{
    public class DescribePhoneInfoRequest : RpcAcsRequest<DescribePhoneInfoResponse>
    {
        public DescribePhoneInfoRequest()
            : base("jarvis", "2018-02-06", "DescribePhoneInfo", "jarvis", "openAPI")
        {
        }

		private string sourceIp;

		private string phoneNum;

		private string lang;

		private string sourceCode;

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string PhoneNum
		{
			get
			{
				return phoneNum;
			}
			set	
			{
				phoneNum = value;
				DictionaryUtil.Add(QueryParameters, "phoneNum", value);
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

		public string SourceCode
		{
			get
			{
				return sourceCode;
			}
			set	
			{
				sourceCode = value;
				DictionaryUtil.Add(QueryParameters, "sourceCode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribePhoneInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribePhoneInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
