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
using Aliyun.Acs.imm.Transform;
using Aliyun.Acs.imm.Transform.V20170906;

namespace Aliyun.Acs.imm.Model.V20170906
{
    public class CreateCADConversionTaskRequest : RpcAcsRequest<CreateCADConversionTaskResponse>
    {
        public CreateCADConversionTaskRequest()
            : base("imm", "2017-09-06", "CreateCADConversionTask", "imm", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string srcType;

		private int? baseRow;

		private string project;

		private int? zoomFactor;

		private string notifyEndpoint;

		private int? baseCol;

		private string notifyTopicName;

		private long? unitWidth;

		private int? zoomLevel;

		private string modelId;

		private string tgtType;

		private long? unitHeight;

		private string srcUri;

		private bool? thumbnails;

		private string tgtUri;

		public string SrcType
		{
			get
			{
				return srcType;
			}
			set	
			{
				srcType = value;
				DictionaryUtil.Add(QueryParameters, "SrcType", value);
			}
		}

		public int? BaseRow
		{
			get
			{
				return baseRow;
			}
			set	
			{
				baseRow = value;
				DictionaryUtil.Add(QueryParameters, "BaseRow", value.ToString());
			}
		}

		public string Project
		{
			get
			{
				return project;
			}
			set	
			{
				project = value;
				DictionaryUtil.Add(QueryParameters, "Project", value);
			}
		}

		public int? ZoomFactor
		{
			get
			{
				return zoomFactor;
			}
			set	
			{
				zoomFactor = value;
				DictionaryUtil.Add(QueryParameters, "ZoomFactor", value.ToString());
			}
		}

		public string NotifyEndpoint
		{
			get
			{
				return notifyEndpoint;
			}
			set	
			{
				notifyEndpoint = value;
				DictionaryUtil.Add(QueryParameters, "NotifyEndpoint", value);
			}
		}

		public int? BaseCol
		{
			get
			{
				return baseCol;
			}
			set	
			{
				baseCol = value;
				DictionaryUtil.Add(QueryParameters, "BaseCol", value.ToString());
			}
		}

		public string NotifyTopicName
		{
			get
			{
				return notifyTopicName;
			}
			set	
			{
				notifyTopicName = value;
				DictionaryUtil.Add(QueryParameters, "NotifyTopicName", value);
			}
		}

		public long? UnitWidth
		{
			get
			{
				return unitWidth;
			}
			set	
			{
				unitWidth = value;
				DictionaryUtil.Add(QueryParameters, "UnitWidth", value.ToString());
			}
		}

		public int? ZoomLevel
		{
			get
			{
				return zoomLevel;
			}
			set	
			{
				zoomLevel = value;
				DictionaryUtil.Add(QueryParameters, "ZoomLevel", value.ToString());
			}
		}

		public string ModelId
		{
			get
			{
				return modelId;
			}
			set	
			{
				modelId = value;
				DictionaryUtil.Add(QueryParameters, "ModelId", value);
			}
		}

		public string TgtType
		{
			get
			{
				return tgtType;
			}
			set	
			{
				tgtType = value;
				DictionaryUtil.Add(QueryParameters, "TgtType", value);
			}
		}

		public long? UnitHeight
		{
			get
			{
				return unitHeight;
			}
			set	
			{
				unitHeight = value;
				DictionaryUtil.Add(QueryParameters, "UnitHeight", value.ToString());
			}
		}

		public string SrcUri
		{
			get
			{
				return srcUri;
			}
			set	
			{
				srcUri = value;
				DictionaryUtil.Add(QueryParameters, "SrcUri", value);
			}
		}

		public bool? Thumbnails
		{
			get
			{
				return thumbnails;
			}
			set	
			{
				thumbnails = value;
				DictionaryUtil.Add(QueryParameters, "Thumbnails", value.ToString());
			}
		}

		public string TgtUri
		{
			get
			{
				return tgtUri;
			}
			set	
			{
				tgtUri = value;
				DictionaryUtil.Add(QueryParameters, "TgtUri", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateCADConversionTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateCADConversionTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
