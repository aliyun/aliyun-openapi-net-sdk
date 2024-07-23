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
    public class SubmitCopyrightJobRequest : RpcAcsRequest<SubmitCopyrightJobResponse>
    {
        public SubmitCopyrightJobRequest()
            : base("Mts", "2014-06-18", "SubmitCopyrightJob", "mts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Mts.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Mts.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string description;

		private string startTime;

		private string output;

		private string userData;

		private long? level;

		private string message;

		private string _params;

		private string url;

		private string input;

		private string totalTime;

		private string callBack;

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
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

		public string UserData
		{
			get
			{
				return userData;
			}
			set	
			{
				userData = value;
				DictionaryUtil.Add(QueryParameters, "UserData", value);
			}
		}

		public long? Level
		{
			get
			{
				return level;
			}
			set	
			{
				level = value;
				DictionaryUtil.Add(QueryParameters, "Level", value.ToString());
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
				DictionaryUtil.Add(QueryParameters, "Message", value);
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

		public string Url
		{
			get
			{
				return url;
			}
			set	
			{
				url = value;
				DictionaryUtil.Add(QueryParameters, "Url", value);
			}
		}

		public string Input
		{
			get
			{
				return input;
			}
			set	
			{
				input = value;
				DictionaryUtil.Add(QueryParameters, "Input", value);
			}
		}

		public string TotalTime
		{
			get
			{
				return totalTime;
			}
			set	
			{
				totalTime = value;
				DictionaryUtil.Add(QueryParameters, "TotalTime", value);
			}
		}

		public string CallBack
		{
			get
			{
				return callBack;
			}
			set	
			{
				callBack = value;
				DictionaryUtil.Add(QueryParameters, "CallBack", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SubmitCopyrightJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitCopyrightJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
