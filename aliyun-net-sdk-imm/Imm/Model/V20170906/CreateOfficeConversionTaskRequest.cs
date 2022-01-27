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
    public class CreateOfficeConversionTaskRequest : RpcAcsRequest<CreateOfficeConversionTaskResponse>
    {
        public CreateOfficeConversionTaskRequest()
            : base("imm", "2017-09-06", "CreateOfficeConversionTask", "imm", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string srcType;

		private string project;

		private string idempotentToken;

		private bool? pdfVector;

		private string userData;

		private string password;

		private long? startPage;

		private string notifyEndpoint;

		private bool? fitToPagesWide;

		private string tgtFilePrefix;

		private string notifyTopicName;

		private string modelId;

		private int? displayDpi;

		private long? maxSheetRow;

		private long? maxSheetCount;

		private long? endPage;

		private string tgtFileSuffix;

		private bool? sheetOnePage;

		private long? maxSheetCol;

		private string tgtType;

		private bool? hidecomments;

		private bool? fitToPagesTall;

		private string srcUri;

		private string tgtFilePages;

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

		public string IdempotentToken
		{
			get
			{
				return idempotentToken;
			}
			set	
			{
				idempotentToken = value;
				DictionaryUtil.Add(QueryParameters, "IdempotentToken", value);
			}
		}

		public bool? PdfVector
		{
			get
			{
				return pdfVector;
			}
			set	
			{
				pdfVector = value;
				DictionaryUtil.Add(QueryParameters, "PdfVector", value.ToString());
			}
		}

		public string UserData
		{
			get
			{
				return userData;
			}
			set	
			{
				userData = value;
				DictionaryUtil.Add(QueryParameters, "UserData", value);
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

		public bool? FitToPagesWide
		{
			get
			{
				return fitToPagesWide;
			}
			set	
			{
				fitToPagesWide = value;
				DictionaryUtil.Add(QueryParameters, "FitToPagesWide", value.ToString());
			}
		}

		public string TgtFilePrefix
		{
			get
			{
				return tgtFilePrefix;
			}
			set	
			{
				tgtFilePrefix = value;
				DictionaryUtil.Add(QueryParameters, "TgtFilePrefix", value);
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

		public int? DisplayDpi
		{
			get
			{
				return displayDpi;
			}
			set	
			{
				displayDpi = value;
				DictionaryUtil.Add(QueryParameters, "DisplayDpi", value.ToString());
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

		public string TgtFileSuffix
		{
			get
			{
				return tgtFileSuffix;
			}
			set	
			{
				tgtFileSuffix = value;
				DictionaryUtil.Add(QueryParameters, "TgtFileSuffix", value);
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

		public bool? Hidecomments
		{
			get
			{
				return hidecomments;
			}
			set	
			{
				hidecomments = value;
				DictionaryUtil.Add(QueryParameters, "Hidecomments", value.ToString());
			}
		}

		public bool? FitToPagesTall
		{
			get
			{
				return fitToPagesTall;
			}
			set	
			{
				fitToPagesTall = value;
				DictionaryUtil.Add(QueryParameters, "FitToPagesTall", value.ToString());
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

		public string TgtFilePages
		{
			get
			{
				return tgtFilePages;
			}
			set	
			{
				tgtFilePages = value;
				DictionaryUtil.Add(QueryParameters, "TgtFilePages", value);
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

        public override CreateOfficeConversionTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateOfficeConversionTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
