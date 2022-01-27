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
using Aliyun.Acs.CDRS;
using Aliyun.Acs.CDRS.Transform;
using Aliyun.Acs.CDRS.Transform.V20201101;

namespace Aliyun.Acs.CDRS.Model.V20201101
{
    public class UpdateProjectRequest : RpcAcsRequest<UpdateProjectResponse>
    {
        public UpdateProjectRequest()
            : base("CDRS", "2020-11-01", "UpdateProject")
        {
			Method = MethodType.POST;
        }

		private string corpId;

		private string icon;

		private string description;

		private string name;

		private string aggregateSceneCode;

		public string CorpId
		{
			get
			{
				return corpId;
			}
			set	
			{
				corpId = value;
				DictionaryUtil.Add(BodyParameters, "CorpId", value);
			}
		}

		public string Icon
		{
			get
			{
				return icon;
			}
			set	
			{
				icon = value;
				DictionaryUtil.Add(BodyParameters, "Icon", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(BodyParameters, "Description", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

		public string AggregateSceneCode
		{
			get
			{
				return aggregateSceneCode;
			}
			set	
			{
				aggregateSceneCode = value;
				DictionaryUtil.Add(BodyParameters, "AggregateSceneCode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateProjectResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateProjectResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
