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
using Aliyun.Acs.cloud_siem.Transform;
using Aliyun.Acs.cloud_siem.Transform.V20220616;

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
    public class DoQuickFieldRequest : RpcAcsRequest<DoQuickFieldResponse>
    {
        public DoQuickFieldRequest()
            : base("cloud-siem", "2022-06-16", "DoQuickField", "cloud-siem", "openAPI")
        {
			Method = MethodType.POST;
        }

		private int? from;

		private string index;

		private bool? reverse;

		private int? size;

		private int? to;

		private int? page;

		public int? From
		{
			get
			{
				return from;
			}
			set	
			{
				from = value;
				DictionaryUtil.Add(BodyParameters, "From", value.ToString());
			}
		}

		public string Index
		{
			get
			{
				return index;
			}
			set	
			{
				index = value;
				DictionaryUtil.Add(BodyParameters, "Index", value);
			}
		}

		public bool? Reverse
		{
			get
			{
				return reverse;
			}
			set	
			{
				reverse = value;
				DictionaryUtil.Add(BodyParameters, "Reverse", value.ToString());
			}
		}

		public int? Size
		{
			get
			{
				return size;
			}
			set	
			{
				size = value;
				DictionaryUtil.Add(BodyParameters, "Size", value.ToString());
			}
		}

		public int? To
		{
			get
			{
				return to;
			}
			set	
			{
				to = value;
				DictionaryUtil.Add(BodyParameters, "To", value.ToString());
			}
		}

		public int? Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
				DictionaryUtil.Add(BodyParameters, "Page", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DoQuickFieldResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DoQuickFieldResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
