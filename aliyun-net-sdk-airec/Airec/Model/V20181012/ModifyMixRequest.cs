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
    public class ModifyMixRequest : RoaAcsRequest<ModifyMixResponse>
    {
        public ModifyMixRequest()
            : base("Airec", "2018-10-12", "ModifyMix", "airec", "openAPI")
        {
			UriPattern = "/openapi/instances/[InstanceId]/mixes/[Name]";
			Method = MethodType.PUT;
        }

		private string instanceId;

		private string name;

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

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(PathParameters, "Name", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyMixResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyMixResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
