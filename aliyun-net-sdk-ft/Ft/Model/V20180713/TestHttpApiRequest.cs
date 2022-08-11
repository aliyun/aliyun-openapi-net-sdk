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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ft;
using Aliyun.Acs.Ft.Transform;
using Aliyun.Acs.Ft.Transform.V20180713;

namespace Aliyun.Acs.Ft.Model.V20180713
{
    public class TestHttpApiRequest : RpcAcsRequest<TestHttpApiResponse>
    {
        public TestHttpApiRequest()
            : base("Ft", "2018-07-13", "TestHttpApi")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ft.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ft.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string stringValue;

		private string otherParam;

		private bool? booleanParam;

		private string defaultValue;

		public string StringValue
		{
			get
			{
				return stringValue;
			}
			set	
			{
				stringValue = value;
				DictionaryUtil.Add(QueryParameters, "StringValue", value);
			}
		}

		public string OtherParam
		{
			get
			{
				return otherParam;
			}
			set	
			{
				otherParam = value;
				DictionaryUtil.Add(QueryParameters, "OtherParam", value);
			}
		}

		public bool? BooleanParam
		{
			get
			{
				return booleanParam;
			}
			set	
			{
				booleanParam = value;
				DictionaryUtil.Add(QueryParameters, "BooleanParam", value.ToString());
			}
		}

		public string DefaultValue
		{
			get
			{
				return defaultValue;
			}
			set	
			{
				defaultValue = value;
				DictionaryUtil.Add(QueryParameters, "DefaultValue", value);
			}
		}

        public override TestHttpApiResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return TestHttpApiResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
