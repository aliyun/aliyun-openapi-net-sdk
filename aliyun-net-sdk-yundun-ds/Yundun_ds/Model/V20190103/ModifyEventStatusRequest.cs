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
using Aliyun.Acs.Yundun_ds.Transform;
using Aliyun.Acs.Yundun_ds.Transform.V20190103;

namespace Aliyun.Acs.Yundun_ds.Model.V20190103
{
    public class ModifyEventStatusRequest : RpcAcsRequest<ModifyEventStatusResponse>
    {
        public ModifyEventStatusRequest()
            : base("Yundun-ds", "2019-01-03", "ModifyEventStatus", "sddp", "openAPI")
        {
        }

		private bool? backed;

		private string dealReason;

		private long? id;

		private string lang;

		private int? featureType;

		private int? status;

		public bool? Backed
		{
			get
			{
				return backed;
			}
			set	
			{
				backed = value;
				DictionaryUtil.Add(QueryParameters, "Backed", value.ToString());
			}
		}

		public string DealReason
		{
			get
			{
				return dealReason;
			}
			set	
			{
				dealReason = value;
				DictionaryUtil.Add(QueryParameters, "DealReason", value);
			}
		}

		public long? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value.ToString());
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public int? FeatureType
		{
			get
			{
				return featureType;
			}
			set	
			{
				featureType = value;
				DictionaryUtil.Add(QueryParameters, "FeatureType", value.ToString());
			}
		}

		public int? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyEventStatusResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyEventStatusResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
