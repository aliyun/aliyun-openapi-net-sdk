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
using Aliyun.Acs.Push.Transform;
using Aliyun.Acs.Push.Transform.V20150827;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Model.V20150827
{
    public class TestRequest : RpcAcsRequest<TestResponse>
    {
        public TestRequest()
            : base("Push", "2015-08-27", "Test")
        {
        }

		private long? appKey;

		private string target;

		private string targetValue;

		private string my_name;

		private long? my_age;

		public long? AppKey
		{
			get
			{
				return appKey;
			}
			set	
			{
				appKey = value;
				DictionaryUtil.Add(QueryParameters, "AppKey", value.ToString());
			}
		}

		public string Target
		{
			get
			{
				return target;
			}
			set	
			{
				target = value;
				DictionaryUtil.Add(QueryParameters, "Target", value);
			}
		}

		public string TargetValue
		{
			get
			{
				return targetValue;
			}
			set	
			{
				targetValue = value;
				DictionaryUtil.Add(QueryParameters, "TargetValue", value);
			}
		}

		public string My_name
		{
			get
			{
				return my_name;
			}
			set	
			{
				my_name = value;
				DictionaryUtil.Add(QueryParameters, "my_name", value);
			}
		}

		public long? My_age
		{
			get
			{
				return my_age;
			}
			set	
			{
				my_age = value;
				DictionaryUtil.Add(QueryParameters, "my_age", value.ToString());
			}
		}

        public override TestResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return TestResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}