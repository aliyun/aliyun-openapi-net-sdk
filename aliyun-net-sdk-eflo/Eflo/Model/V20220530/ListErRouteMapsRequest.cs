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
    public class ListErRouteMapsRequest : RpcAcsRequest<ListErRouteMapsResponse>
    {
        public ListErRouteMapsRequest()
            : base("eflo", "2022-05-30", "ListErRouteMaps", "eflo", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string receptionInstanceType;

		private string receptionInstanceId;

		private int? erRouteMapNum;

		private int? pageNumber;

		private string resourceGroupId;

		private string routeMapAction;

		private string transmissionInstanceType;

		private int? pageSize;

		private string transmissionInstanceName;

		private string destinationCidrBlock;

		private string erId;

		private string erRouteMapId;

		private string receptionInstanceName;

		private bool? enablePage;

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

		public int? ErRouteMapNum
		{
			get
			{
				return erRouteMapNum;
			}
			set	
			{
				erRouteMapNum = value;
				DictionaryUtil.Add(BodyParameters, "ErRouteMapNum", value.ToString());
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(BodyParameters, "ResourceGroupId", value);
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

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public string TransmissionInstanceName
		{
			get
			{
				return transmissionInstanceName;
			}
			set	
			{
				transmissionInstanceName = value;
				DictionaryUtil.Add(BodyParameters, "TransmissionInstanceName", value);
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

		public string ErRouteMapId
		{
			get
			{
				return erRouteMapId;
			}
			set	
			{
				erRouteMapId = value;
				DictionaryUtil.Add(BodyParameters, "ErRouteMapId", value);
			}
		}

		public string ReceptionInstanceName
		{
			get
			{
				return receptionInstanceName;
			}
			set	
			{
				receptionInstanceName = value;
				DictionaryUtil.Add(BodyParameters, "ReceptionInstanceName", value);
			}
		}

		public bool? EnablePage
		{
			get
			{
				return enablePage;
			}
			set	
			{
				enablePage = value;
				DictionaryUtil.Add(BodyParameters, "EnablePage", value.ToString());
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

        public override ListErRouteMapsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListErRouteMapsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
