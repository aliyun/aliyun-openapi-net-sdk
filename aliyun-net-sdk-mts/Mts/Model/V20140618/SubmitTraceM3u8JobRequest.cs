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
using Aliyun.Acs.Mts.Transform;
using Aliyun.Acs.Mts.Transform.V20140618;

namespace Aliyun.Acs.Mts.Model.V20140618
{
    public class SubmitTraceM3u8JobRequest : RpcAcsRequest<SubmitTraceM3u8JobResponse>
    {
        public SubmitTraceM3u8JobRequest()
            : base("Mts", "2014-06-18", "SubmitTraceM3u8Job", "mts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Mts.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Mts.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string mediaId;

		private string _params;

		private string output;

		private string trace;

		private string keyUri;

		public string MediaId
		{
			get
			{
				return mediaId;
			}
			set	
			{
				mediaId = value;
				DictionaryUtil.Add(QueryParameters, "MediaId", value);
			}
		}

		public string _Params
		{
			get
			{
				return _params;
			}
			set	
			{
				_params = value;
				DictionaryUtil.Add(QueryParameters, "Params", value);
			}
		}

		public string Output
		{
			get
			{
				return output;
			}
			set	
			{
				output = value;
				DictionaryUtil.Add(QueryParameters, "Output", value);
			}
		}

		public string Trace
		{
			get
			{
				return trace;
			}
			set	
			{
				trace = value;
				DictionaryUtil.Add(QueryParameters, "Trace", value);
			}
		}

		public string KeyUri
		{
			get
			{
				return keyUri;
			}
			set	
			{
				keyUri = value;
				DictionaryUtil.Add(QueryParameters, "KeyUri", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SubmitTraceM3u8JobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitTraceM3u8JobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
