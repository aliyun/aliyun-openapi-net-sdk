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
using Aliyun.Acs.Airec.Transform;
using Aliyun.Acs.Airec.Transform.V20181012;

namespace Aliyun.Acs.Airec.Model.V20181012
{
    public class RecommendRequest : RoaAcsRequest<RecommendResponse>
    {
        public RecommendRequest()
            : base("Airec", "2018-10-12", "Recommend", "airec", "openAPI")
        {
			UriPattern = "/openapi/instances/[InstanceId]/actions/recommend";
			Method = MethodType.GET;
        }

		private int? returnCount;

		private string instanceId;

		private string ip;

		private string sceneId;

		private string imei;

		private string userId;

		public int? ReturnCount
		{
			get
			{
				return returnCount;
			}
			set	
			{
				returnCount = value;
				DictionaryUtil.Add(QueryParameters, "ReturnCount", value.ToString());
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
				DictionaryUtil.Add(PathParameters, "InstanceId", value);
			}
		}

		public string Ip
		{
			get
			{
				return ip;
			}
			set	
			{
				ip = value;
				DictionaryUtil.Add(QueryParameters, "Ip", value);
			}
		}

		public string SceneId
		{
			get
			{
				return sceneId;
			}
			set	
			{
				sceneId = value;
				DictionaryUtil.Add(QueryParameters, "SceneId", value);
			}
		}

		public string Imei
		{
			get
			{
				return imei;
			}
			set	
			{
				imei = value;
				DictionaryUtil.Add(QueryParameters, "Imei", value);
			}
		}

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RecommendResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RecommendResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
