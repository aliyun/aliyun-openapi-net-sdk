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
using Aliyun.Acs.cas.Transform;
using Aliyun.Acs.cas.Transform.V20180813;

namespace Aliyun.Acs.cas.Model.V20180813
{
    public class CreateSignatureRequest : RpcAcsRequest<CreateSignatureResponse>
    {
        public CreateSignatureRequest()
            : base("cas", "2018-08-13", "CreateSignature", "cas_esign_fdd", "openAPI")
        {
        }

		private int? quantity;

		private string handSignImg;

		private string docId;

		private string customApi;

		private int? positionPage;

		private string docTitle;

		private int? positionX;

		private int? positionY;

		private string sourceIp;

		private string peopleId;

		private int? positionType;

		private string signKeyword;

		private string notifyUrl;

		private int? validity;

		private string returnUrl;

		private string lang;

		private int? keywordStrategy;

		public int? Quantity
		{
			get
			{
				return quantity;
			}
			set	
			{
				quantity = value;
				DictionaryUtil.Add(QueryParameters, "Quantity", value.ToString());
			}
		}

		public string HandSignImg
		{
			get
			{
				return handSignImg;
			}
			set	
			{
				handSignImg = value;
				DictionaryUtil.Add(QueryParameters, "HandSignImg", value);
			}
		}

		public string DocId
		{
			get
			{
				return docId;
			}
			set	
			{
				docId = value;
				DictionaryUtil.Add(QueryParameters, "DocId", value);
			}
		}

		public string CustomApi
		{
			get
			{
				return customApi;
			}
			set	
			{
				customApi = value;
				DictionaryUtil.Add(QueryParameters, "CustomApi", value);
			}
		}

		public int? PositionPage
		{
			get
			{
				return positionPage;
			}
			set	
			{
				positionPage = value;
				DictionaryUtil.Add(QueryParameters, "PositionPage", value.ToString());
			}
		}

		public string DocTitle
		{
			get
			{
				return docTitle;
			}
			set	
			{
				docTitle = value;
				DictionaryUtil.Add(QueryParameters, "DocTitle", value);
			}
		}

		public int? PositionX
		{
			get
			{
				return positionX;
			}
			set	
			{
				positionX = value;
				DictionaryUtil.Add(QueryParameters, "PositionX", value.ToString());
			}
		}

		public int? PositionY
		{
			get
			{
				return positionY;
			}
			set	
			{
				positionY = value;
				DictionaryUtil.Add(QueryParameters, "PositionY", value.ToString());
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string PeopleId
		{
			get
			{
				return peopleId;
			}
			set	
			{
				peopleId = value;
				DictionaryUtil.Add(QueryParameters, "PeopleId", value);
			}
		}

		public int? PositionType
		{
			get
			{
				return positionType;
			}
			set	
			{
				positionType = value;
				DictionaryUtil.Add(QueryParameters, "PositionType", value.ToString());
			}
		}

		public string SignKeyword
		{
			get
			{
				return signKeyword;
			}
			set	
			{
				signKeyword = value;
				DictionaryUtil.Add(QueryParameters, "SignKeyword", value);
			}
		}

		public string NotifyUrl
		{
			get
			{
				return notifyUrl;
			}
			set	
			{
				notifyUrl = value;
				DictionaryUtil.Add(QueryParameters, "NotifyUrl", value);
			}
		}

		public int? Validity
		{
			get
			{
				return validity;
			}
			set	
			{
				validity = value;
				DictionaryUtil.Add(QueryParameters, "Validity", value.ToString());
			}
		}

		public string ReturnUrl
		{
			get
			{
				return returnUrl;
			}
			set	
			{
				returnUrl = value;
				DictionaryUtil.Add(QueryParameters, "ReturnUrl", value);
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

		public int? KeywordStrategy
		{
			get
			{
				return keywordStrategy;
			}
			set	
			{
				keywordStrategy = value;
				DictionaryUtil.Add(QueryParameters, "KeywordStrategy", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateSignatureResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateSignatureResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
