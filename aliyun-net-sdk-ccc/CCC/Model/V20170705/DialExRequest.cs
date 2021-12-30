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
using Aliyun.Acs.CCC;
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20170705;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class DialExRequest : RpcAcsRequest<DialExResponse>
    {
        public DialExRequest()
            : base("CCC", "2017-07-05", "DialEx")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string callee;

		private string routPoint;

		private string caller;

		private string instanceId;

		private string provider;

		private int? answerMode;

		public string Callee
		{
			get
			{
				return callee;
			}
			set	
			{
				callee = value;
				DictionaryUtil.Add(QueryParameters, "Callee", value);
			}
		}

		public string RoutPoint
		{
			get
			{
				return routPoint;
			}
			set	
			{
				routPoint = value;
				DictionaryUtil.Add(QueryParameters, "RoutPoint", value);
			}
		}

		public string Caller
		{
			get
			{
				return caller;
			}
			set	
			{
				caller = value;
				DictionaryUtil.Add(QueryParameters, "Caller", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string Provider
		{
			get
			{
				return provider;
			}
			set	
			{
				provider = value;
				DictionaryUtil.Add(QueryParameters, "Provider", value);
			}
		}

		public int? AnswerMode
		{
			get
			{
				return answerMode;
			}
			set	
			{
				answerMode = value;
				DictionaryUtil.Add(QueryParameters, "AnswerMode", value.ToString());
			}
		}

        public override DialExResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DialExResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
