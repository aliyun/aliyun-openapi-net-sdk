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
using Aliyun.Acs.MoPen.Transform;
using Aliyun.Acs.MoPen.Transform.V20180211;

namespace Aliyun.Acs.MoPen.Model.V20180211
{
    public class MoPenDoRecognizeRequest : RpcAcsRequest<MoPenDoRecognizeResponse>
    {
        public MoPenDoRecognizeRequest()
            : base("MoPen", "2018-02-11", "MoPenDoRecognize", "mopen", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private long? canvasId;

		private int? endY;

		private int? endX;

		private string jsonConf;

		private string exportType;

		private int? startY;

		private int? startX;

		public long? CanvasId
		{
			get
			{
				return canvasId;
			}
			set	
			{
				canvasId = value;
				DictionaryUtil.Add(BodyParameters, "CanvasId", value.ToString());
			}
		}

		public int? EndY
		{
			get
			{
				return endY;
			}
			set	
			{
				endY = value;
				DictionaryUtil.Add(BodyParameters, "EndY", value.ToString());
			}
		}

		public int? EndX
		{
			get
			{
				return endX;
			}
			set	
			{
				endX = value;
				DictionaryUtil.Add(BodyParameters, "EndX", value.ToString());
			}
		}

		public string JsonConf
		{
			get
			{
				return jsonConf;
			}
			set	
			{
				jsonConf = value;
				DictionaryUtil.Add(BodyParameters, "JsonConf", value);
			}
		}

		public string ExportType
		{
			get
			{
				return exportType;
			}
			set	
			{
				exportType = value;
				DictionaryUtil.Add(BodyParameters, "ExportType", value);
			}
		}

		public int? StartY
		{
			get
			{
				return startY;
			}
			set	
			{
				startY = value;
				DictionaryUtil.Add(BodyParameters, "StartY", value.ToString());
			}
		}

		public int? StartX
		{
			get
			{
				return startX;
			}
			set	
			{
				startX = value;
				DictionaryUtil.Add(BodyParameters, "StartX", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override MoPenDoRecognizeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return MoPenDoRecognizeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
