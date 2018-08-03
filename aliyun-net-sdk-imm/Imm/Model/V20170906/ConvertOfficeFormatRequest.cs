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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.imm.Transform;
using Aliyun.Acs.imm.Transform.V20170906;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Model.V20170906
{
    public class ConvertOfficeFormatRequest : RpcAcsRequest<ConvertOfficeFormatResponse>
    {
        public ConvertOfficeFormatRequest()
            : base("imm", "2017-09-06", "ConvertOfficeFormat", "imm", "openAPI")
        {
        }

		private string imageSpec;

		private string srcType;

		private string modelId;

		private string project;

		private string externalID;

		private long? maxSheetRow;

		private long? maxSheetCount;

		private long? endPage;

		private string accessKeyId;

		private bool? sheetOnePage;

		private string password;

		private long? startPage;

		private long? maxSheetCol;

		private string tgtType;

		private string action;

		private string srcUri;

		private string tgtUri;

		public string ImageSpec
		{
			get
			{
				return imageSpec;
			}
			set	
			{
				imageSpec = value;
				DictionaryUtil.Add(QueryParameters, "ImageSpec", value);
			}
		}

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

		public string ExternalID
		{
			get
			{
				return externalID;
			}
			set	
			{
				externalID = value;
				DictionaryUtil.Add(QueryParameters, "ExternalID", value);
			}
		}

		public long? MaxSheetRow
		{
			get
			{
				return maxSheetRow;
			}
			set	
			{
				maxSheetRow = value;
				DictionaryUtil.Add(QueryParameters, "MaxSheetRow", value.ToString());
			}
		}

		public long? MaxSheetCount
		{
			get
			{
				return maxSheetCount;
			}
			set	
			{
				maxSheetCount = value;
				DictionaryUtil.Add(QueryParameters, "MaxSheetCount", value.ToString());
			}
		}

		public long? EndPage
		{
			get
			{
				return endPage;
			}
			set	
			{
				endPage = value;
				DictionaryUtil.Add(QueryParameters, "EndPage", value.ToString());
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public bool? SheetOnePage
		{
			get
			{
				return sheetOnePage;
			}
			set	
			{
				sheetOnePage = value;
				DictionaryUtil.Add(QueryParameters, "SheetOnePage", value.ToString());
			}
		}

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
				DictionaryUtil.Add(QueryParameters, "Password", value);
			}
		}

		public long? StartPage
		{
			get
			{
				return startPage;
			}
			set	
			{
				startPage = value;
				DictionaryUtil.Add(QueryParameters, "StartPage", value.ToString());
			}
		}

		public long? MaxSheetCol
		{
			get
			{
				return maxSheetCol;
			}
			set	
			{
				maxSheetCol = value;
				DictionaryUtil.Add(QueryParameters, "MaxSheetCol", value.ToString());
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

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
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

        public override ConvertOfficeFormatResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ConvertOfficeFormatResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}