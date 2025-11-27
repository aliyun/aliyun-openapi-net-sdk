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
using Aliyun.Acs.Dms;
using Aliyun.Acs.Dms.Transform;
using Aliyun.Acs.Dms.Transform.V20250414;

namespace Aliyun.Acs.Dms.Model.V20250414
{
    public class CreateAirflowLoginTokenRequest : RpcAcsRequest<CreateAirflowLoginTokenResponse>
    {
        public CreateAirflowLoginTokenRequest()
            : base("Dms", "2025-04-14", "CreateAirflowLoginToken")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string airflowId;

		public string AirflowId
		{
			get
			{
				return airflowId;
			}
			set	
			{
				airflowId = value;
				DictionaryUtil.Add(QueryParameters, "AirflowId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateAirflowLoginTokenResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateAirflowLoginTokenResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
