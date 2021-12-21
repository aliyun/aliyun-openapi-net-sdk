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
using Aliyun.Acs.schedulerx2;
using Aliyun.Acs.schedulerx2.Transform;
using Aliyun.Acs.schedulerx2.Transform.V20190430;

namespace Aliyun.Acs.schedulerx2.Model.V20190430
{
    public class DesignateWorkersRequest : RpcAcsRequest<DesignateWorkersResponse>
    {
        public DesignateWorkersRequest()
            : base("schedulerx2", "2019-04-30", "DesignateWorkers")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.schedulerx2.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.schedulerx2.Endpoint.endpointRegionalType, null);
            }
        }

		private string namespaceSource;

		private string groupId;

		private bool? transferable;

		private string labels;

		private int? designateType;

		private long? jobId;

		private string _namespace;

		private string workers;

		public string NamespaceSource
		{
			get
			{
				return namespaceSource;
			}
			set	
			{
				namespaceSource = value;
				DictionaryUtil.Add(QueryParameters, "NamespaceSource", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public bool? Transferable
		{
			get
			{
				return transferable;
			}
			set	
			{
				transferable = value;
				DictionaryUtil.Add(QueryParameters, "Transferable", value.ToString());
			}
		}

		public string Labels
		{
			get
			{
				return labels;
			}
			set	
			{
				labels = value;
				DictionaryUtil.Add(QueryParameters, "Labels", value);
			}
		}

		public int? DesignateType
		{
			get
			{
				return designateType;
			}
			set	
			{
				designateType = value;
				DictionaryUtil.Add(QueryParameters, "DesignateType", value.ToString());
			}
		}

		public long? JobId
		{
			get
			{
				return jobId;
			}
			set	
			{
				jobId = value;
				DictionaryUtil.Add(QueryParameters, "JobId", value.ToString());
			}
		}

		public string _Namespace
		{
			get
			{
				return _namespace;
			}
			set	
			{
				_namespace = value;
				DictionaryUtil.Add(QueryParameters, "Namespace", value);
			}
		}

		public string Workers
		{
			get
			{
				return workers;
			}
			set	
			{
				workers = value;
				DictionaryUtil.Add(QueryParameters, "Workers", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DesignateWorkersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DesignateWorkersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
