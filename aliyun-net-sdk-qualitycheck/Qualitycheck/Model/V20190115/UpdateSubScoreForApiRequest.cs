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
using Aliyun.Acs.Qualitycheck;
using Aliyun.Acs.Qualitycheck.Transform;
using Aliyun.Acs.Qualitycheck.Transform.V20190115;

namespace Aliyun.Acs.Qualitycheck.Model.V20190115
{
    public class UpdateSubScoreForApiRequest : RpcAcsRequest<UpdateSubScoreForApiResponse>
    {
        public UpdateSubScoreForApiRequest()
            : base("Qualitycheck", "2019-01-15", "UpdateSubScoreForApi")
        {
			Method = MethodType.POST;
        }

		private string jsonStr;

		public string JsonStr
		{
			get
			{
				return jsonStr;
			}
			set	
			{
				jsonStr = value;
				DictionaryUtil.Add(QueryParameters, "JsonStr", value);
			}
		}

        public override UpdateSubScoreForApiResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateSubScoreForApiResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
