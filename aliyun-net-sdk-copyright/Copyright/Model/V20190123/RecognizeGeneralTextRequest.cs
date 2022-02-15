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
using Aliyun.Acs.Copyright;
using Aliyun.Acs.Copyright.Transform;
using Aliyun.Acs.Copyright.Transform.V20190123;

namespace Aliyun.Acs.Copyright.Model.V20190123
{
    public class RecognizeGeneralTextRequest : RpcAcsRequest<RecognizeGeneralTextResponse>
    {
        public RecognizeGeneralTextRequest()
            : base("Copyright", "2019-01-23", "RecognizeGeneralText")
        {
			Method = MethodType.POST;
        }

		private string data;

		private string bizCode;

		private string fileInfo;

		private string label;

		private string text;

		private string fileProcessType;

		private string type;

		public string Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
				DictionaryUtil.Add(BodyParameters, "Data", value);
			}
		}

		public string BizCode
		{
			get
			{
				return bizCode;
			}
			set	
			{
				bizCode = value;
				DictionaryUtil.Add(QueryParameters, "BizCode", value);
			}
		}

		public string FileInfo
		{
			get
			{
				return fileInfo;
			}
			set	
			{
				fileInfo = value;
				DictionaryUtil.Add(QueryParameters, "FileInfo", value);
			}
		}

		public string Label
		{
			get
			{
				return label;
			}
			set	
			{
				label = value;
				DictionaryUtil.Add(BodyParameters, "Label", value);
			}
		}

		public string Text
		{
			get
			{
				return text;
			}
			set	
			{
				text = value;
				DictionaryUtil.Add(QueryParameters, "Text", value);
			}
		}

		public string FileProcessType
		{
			get
			{
				return fileProcessType;
			}
			set	
			{
				fileProcessType = value;
				DictionaryUtil.Add(QueryParameters, "FileProcessType", value);
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RecognizeGeneralTextResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RecognizeGeneralTextResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
