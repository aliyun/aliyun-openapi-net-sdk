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
using Aliyun.Acs.ROS.Transform;
using Aliyun.Acs.ROS.Transform.V20150901;

namespace Aliyun.Acs.ROS.Model.V20150901
{
    public class WaitConditionsRequest : RoaAcsRequest<WaitConditionsResponse>
    {
        public WaitConditionsRequest()
            : base("ROS", "2015-09-01", "WaitConditions", "ros", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ROS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ROS.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/waitcondition";
			Method = MethodType.POST;
        }

		private string resource;

		private string signature;

		private string stackid;

		private string expire;

		private string stackname;

		public string Resource
		{
			get
			{
				return resource;
			}
			set	
			{
				resource = value;
				DictionaryUtil.Add(QueryParameters, "resource", value);
			}
		}

		public string Signature
		{
			get
			{
				return signature;
			}
			set	
			{
				signature = value;
				DictionaryUtil.Add(QueryParameters, "signature", value);
			}
		}

		public string Stackid
		{
			get
			{
				return stackid;
			}
			set	
			{
				stackid = value;
				DictionaryUtil.Add(QueryParameters, "stackid", value);
			}
		}

		public string Expire
		{
			get
			{
				return expire;
			}
			set	
			{
				expire = value;
				DictionaryUtil.Add(QueryParameters, "expire", value);
			}
		}

		public string Stackname
		{
			get
			{
				return stackname;
			}
			set	
			{
				stackname = value;
				DictionaryUtil.Add(QueryParameters, "stackname", value);
			}
		}

        public override WaitConditionsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return WaitConditionsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
