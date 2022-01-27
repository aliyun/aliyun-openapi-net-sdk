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
using Aliyun.Acs.nlp_automl.Transform;
using Aliyun.Acs.nlp_automl.Transform.V20190701;

namespace Aliyun.Acs.nlp_automl.Model.V20190701
{
    public class PredictMTModelByDocRequest : RpcAcsRequest<PredictMTModelByDocResponse>
    {
        public PredictMTModelByDocRequest()
            : base("nlp-automl", "2019-07-01", "PredictMTModelByDoc", "nlpautoml", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.nlp_automl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.nlp_automl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string fileType;

		private int? modelId;

		private string fileContent;

		private bool? needXLIFF;

		private string modelVersion;

		public string FileType
		{
			get
			{
				return fileType;
			}
			set	
			{
				fileType = value;
				DictionaryUtil.Add(QueryParameters, "FileType", value);
			}
		}

		public int? ModelId
		{
			get
			{
				return modelId;
			}
			set	
			{
				modelId = value;
				DictionaryUtil.Add(QueryParameters, "ModelId", value.ToString());
			}
		}

		public string FileContent
		{
			get
			{
				return fileContent;
			}
			set	
			{
				fileContent = value;
				DictionaryUtil.Add(BodyParameters, "FileContent", value);
			}
		}

		public bool? NeedXLIFF
		{
			get
			{
				return needXLIFF;
			}
			set	
			{
				needXLIFF = value;
				DictionaryUtil.Add(QueryParameters, "NeedXLIFF", value.ToString());
			}
		}

		public string ModelVersion
		{
			get
			{
				return modelVersion;
			}
			set	
			{
				modelVersion = value;
				DictionaryUtil.Add(QueryParameters, "ModelVersion", value);
			}
		}

        public override PredictMTModelByDocResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PredictMTModelByDocResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
