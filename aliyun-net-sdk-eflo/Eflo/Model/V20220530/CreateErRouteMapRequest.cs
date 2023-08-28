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
using Aliyun.Acs.eflo.Transform;
using Aliyun.Acs.eflo.Transform.V20220530;

namespace Aliyun.Acs.eflo.Model.V20220530
{
    public class CreateErRouteMapRequest : RpcAcsRequest<CreateErRouteMapResponse>
    {
        public CreateErRouteMapRequest()
            : base("eflo", "2022-05-30", "CreateErRouteMap", "eflo", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string receptionInstanceType;

		private string description;

		private string receptionInstanceId;

		private string routeMapAction;

		private string transmissionInstanceType;

		private string destinationCidrBlock;

		private string erId;

		private int? routeMapNum;

		private string receptionInstanceOwner;

		private string transmissionInstanceOwner;

		private string transmissionInstanceId;

		public string ReceptionInstanceType
		{
			get
			{
				return receptionInstanceType;
			}
			set	
			{
				receptionInstanceType = value;
				DictionaryUtil.Add(BodyParameters, "ReceptionInstanceType", value);
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

		public string ReceptionInstanceId
		{
			get
			{
				return receptionInstanceId;
			}
			set	
			{
				receptionInstanceId = value;
				DictionaryUtil.Add(BodyParameters, "ReceptionInstanceId", value);
			}
		}

		public string RouteMapAction
		{
			get
			{
				return routeMapAction;
			}
			set	
			{
				routeMapAction = value;
				DictionaryUtil.Add(BodyParameters, "RouteMapAction", value);
			}
		}

		public string TransmissionInstanceType
		{
			get
			{
				return transmissionInstanceType;
			}
			set	
			{
				transmissionInstanceType = value;
				DictionaryUtil.Add(BodyParameters, "TransmissionInstanceType", value);
			}
		}

		public string DestinationCidrBlock
		{
			get
			{
				return destinationCidrBlock;
			}
			set	
			{
				destinationCidrBlock = value;
				DictionaryUtil.Add(BodyParameters, "DestinationCidrBlock", value);
			}
		}

		public string ErId
		{
			get
			{
				return erId;
			}
			set	
			{
				erId = value;
				DictionaryUtil.Add(BodyParameters, "ErId", value);
			}
		}

		public int? RouteMapNum
		{
			get
			{
				return routeMapNum;
			}
			set	
			{
				routeMapNum = value;
				DictionaryUtil.Add(BodyParameters, "RouteMapNum", value.ToString());
			}
		}

		public string ReceptionInstanceOwner
		{
			get
			{
				return receptionInstanceOwner;
			}
			set	
			{
				receptionInstanceOwner = value;
				DictionaryUtil.Add(BodyParameters, "ReceptionInstanceOwner", value);
			}
		}

		public string TransmissionInstanceOwner
		{
			get
			{
				return transmissionInstanceOwner;
			}
			set	
			{
				transmissionInstanceOwner = value;
				DictionaryUtil.Add(BodyParameters, "TransmissionInstanceOwner", value);
			}
		}

		public string TransmissionInstanceId
		{
			get
			{
				return transmissionInstanceId;
			}
			set	
			{
				transmissionInstanceId = value;
				DictionaryUtil.Add(BodyParameters, "TransmissionInstanceId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateErRouteMapResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateErRouteMapResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
