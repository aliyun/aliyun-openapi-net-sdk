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
using Aliyun.Acs.ocr.Transform;
using Aliyun.Acs.ocr.Transform.V20191230;

namespace Aliyun.Acs.ocr.Model.V20191230
{
    public class RecognizeTableRequest : RpcAcsRequest<RecognizeTableResponse>
    {
        public RecognizeTableRequest()
            : base("ocr", "2019-12-30", "RecognizeTable", "ocr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ocr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ocr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? useFinanceModel;

		private bool? skipDetection;

		private string imageURL;

		private string outputFormat;

		private bool? assureDirection;

		private bool? hasLine;

		public bool? UseFinanceModel
		{
			get
			{
				return useFinanceModel;
			}
			set	
			{
				useFinanceModel = value;
				DictionaryUtil.Add(BodyParameters, "UseFinanceModel", value.ToString());
			}
		}

		public bool? SkipDetection
		{
			get
			{
				return skipDetection;
			}
			set	
			{
				skipDetection = value;
				DictionaryUtil.Add(BodyParameters, "SkipDetection", value.ToString());
			}
		}

		public string ImageURL
		{
			get
			{
				return imageURL;
			}
			set	
			{
				imageURL = value;
				DictionaryUtil.Add(BodyParameters, "ImageURL", value);
			}
		}

		public string OutputFormat
		{
			get
			{
				return outputFormat;
			}
			set	
			{
				outputFormat = value;
				DictionaryUtil.Add(BodyParameters, "OutputFormat", value);
			}
		}

		public bool? AssureDirection
		{
			get
			{
				return assureDirection;
			}
			set	
			{
				assureDirection = value;
				DictionaryUtil.Add(BodyParameters, "AssureDirection", value.ToString());
			}
		}

		public bool? HasLine
		{
			get
			{
				return hasLine;
			}
			set	
			{
				hasLine = value;
				DictionaryUtil.Add(BodyParameters, "HasLine", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RecognizeTableResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RecognizeTableResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
