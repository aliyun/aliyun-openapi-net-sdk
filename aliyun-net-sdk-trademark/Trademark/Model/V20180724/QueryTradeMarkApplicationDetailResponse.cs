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

namespace Aliyun.Acs.Trademark.Model.V20180724
{
	public class QueryTradeMarkApplicationDetailResponse : AcsResponse
	{

		private int? status;

		private string requestId;

		private string loaUrl;

		private float? orderPrice;

		private string tmIcon;

		private string orderId;

		private int? type;

		private int? tmNameType;

		private string tmName;

		private string bizId;

		private string grayIconUrl;

		private string note;

		private string tmNumber;

		private string acceptUrl;

		private long? createTime;

		private long? updateTime;

		private string extendInfo;

		private string sendSbjLogistics;

		private string sendUserLogistics;

		private string recvUserLogistics;

		private long? materialId;

		private float? totalPrice;

		private float? servicePrice;

		private string partnerCode;

		private string partnerMobile;

		private string notAcceptUrl;

		private string partnerName;

		private List<QueryTradeMarkApplicationDetail_ThirdClassifications> thirdClassification;

		private List<QueryTradeMarkApplicationDetail_SupplementsItem> supplements;

		private List<string> receiptUrl;

		private List<string> judgeResultUrl;

		private List<string> flags;

		private QueryTradeMarkApplicationDetail_AdminUploads adminUploads;

		private QueryTradeMarkApplicationDetail_MaterialDetail materialDetail;

		private QueryTradeMarkApplicationDetail_FirstClassification firstClassification;

		private QueryTradeMarkApplicationDetail_RenewResponse renewResponse;

		private QueryTradeMarkApplicationDetail_ReviewOfficialFiles reviewOfficialFiles;

		public int? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string LoaUrl
		{
			get
			{
				return loaUrl;
			}
			set	
			{
				loaUrl = value;
			}
		}

		public float? OrderPrice
		{
			get
			{
				return orderPrice;
			}
			set	
			{
				orderPrice = value;
			}
		}

		public string TmIcon
		{
			get
			{
				return tmIcon;
			}
			set	
			{
				tmIcon = value;
			}
		}

		public string OrderId
		{
			get
			{
				return orderId;
			}
			set	
			{
				orderId = value;
			}
		}

		public int? Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
			}
		}

		public int? TmNameType
		{
			get
			{
				return tmNameType;
			}
			set	
			{
				tmNameType = value;
			}
		}

		public string TmName
		{
			get
			{
				return tmName;
			}
			set	
			{
				tmName = value;
			}
		}

		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
			}
		}

		public string GrayIconUrl
		{
			get
			{
				return grayIconUrl;
			}
			set	
			{
				grayIconUrl = value;
			}
		}

		public string Note
		{
			get
			{
				return note;
			}
			set	
			{
				note = value;
			}
		}

		public string TmNumber
		{
			get
			{
				return tmNumber;
			}
			set	
			{
				tmNumber = value;
			}
		}

		public string AcceptUrl
		{
			get
			{
				return acceptUrl;
			}
			set	
			{
				acceptUrl = value;
			}
		}

		public long? CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		public long? UpdateTime
		{
			get
			{
				return updateTime;
			}
			set	
			{
				updateTime = value;
			}
		}

		public string ExtendInfo
		{
			get
			{
				return extendInfo;
			}
			set	
			{
				extendInfo = value;
			}
		}

		public string SendSbjLogistics
		{
			get
			{
				return sendSbjLogistics;
			}
			set	
			{
				sendSbjLogistics = value;
			}
		}

		public string SendUserLogistics
		{
			get
			{
				return sendUserLogistics;
			}
			set	
			{
				sendUserLogistics = value;
			}
		}

		public string RecvUserLogistics
		{
			get
			{
				return recvUserLogistics;
			}
			set	
			{
				recvUserLogistics = value;
			}
		}

		public long? MaterialId
		{
			get
			{
				return materialId;
			}
			set	
			{
				materialId = value;
			}
		}

		public float? TotalPrice
		{
			get
			{
				return totalPrice;
			}
			set	
			{
				totalPrice = value;
			}
		}

		public float? ServicePrice
		{
			get
			{
				return servicePrice;
			}
			set	
			{
				servicePrice = value;
			}
		}

		public string PartnerCode
		{
			get
			{
				return partnerCode;
			}
			set	
			{
				partnerCode = value;
			}
		}

		public string PartnerMobile
		{
			get
			{
				return partnerMobile;
			}
			set	
			{
				partnerMobile = value;
			}
		}

		public string NotAcceptUrl
		{
			get
			{
				return notAcceptUrl;
			}
			set	
			{
				notAcceptUrl = value;
			}
		}

		public string PartnerName
		{
			get
			{
				return partnerName;
			}
			set	
			{
				partnerName = value;
			}
		}

		public List<QueryTradeMarkApplicationDetail_ThirdClassifications> ThirdClassification
		{
			get
			{
				return thirdClassification;
			}
			set	
			{
				thirdClassification = value;
			}
		}

		public List<QueryTradeMarkApplicationDetail_SupplementsItem> Supplements
		{
			get
			{
				return supplements;
			}
			set	
			{
				supplements = value;
			}
		}

		public List<string> ReceiptUrl
		{
			get
			{
				return receiptUrl;
			}
			set	
			{
				receiptUrl = value;
			}
		}

		public List<string> JudgeResultUrl
		{
			get
			{
				return judgeResultUrl;
			}
			set	
			{
				judgeResultUrl = value;
			}
		}

		public List<string> Flags
		{
			get
			{
				return flags;
			}
			set	
			{
				flags = value;
			}
		}

		public QueryTradeMarkApplicationDetail_AdminUploads AdminUploads
		{
			get
			{
				return adminUploads;
			}
			set	
			{
				adminUploads = value;
			}
		}

		public QueryTradeMarkApplicationDetail_MaterialDetail MaterialDetail
		{
			get
			{
				return materialDetail;
			}
			set	
			{
				materialDetail = value;
			}
		}

		public QueryTradeMarkApplicationDetail_FirstClassification FirstClassification
		{
			get
			{
				return firstClassification;
			}
			set	
			{
				firstClassification = value;
			}
		}

		public QueryTradeMarkApplicationDetail_RenewResponse RenewResponse
		{
			get
			{
				return renewResponse;
			}
			set	
			{
				renewResponse = value;
			}
		}

		public QueryTradeMarkApplicationDetail_ReviewOfficialFiles ReviewOfficialFiles
		{
			get
			{
				return reviewOfficialFiles;
			}
			set	
			{
				reviewOfficialFiles = value;
			}
		}

		public class QueryTradeMarkApplicationDetail_ThirdClassifications
		{

			private string code;

			private string name;

			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}
		}

		public class QueryTradeMarkApplicationDetail_SupplementsItem
		{

			private long? id;

			private string serialNumber;

			private int? type;

			private int? status;

			private string orderId;

			private string tmNumber;

			private long? sendTime;

			private long? acceptTime;

			private long? sbjDeadTime;

			private long? acceptDeadTime;

			private string uploadFileTemplateUrl;

			private string content;

			private string batchNum;

			private long? operateTime;

			private List<string> fileTemplateUrls;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string SerialNumber
			{
				get
				{
					return serialNumber;
				}
				set	
				{
					serialNumber = value;
				}
			}

			public int? Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string OrderId
			{
				get
				{
					return orderId;
				}
				set	
				{
					orderId = value;
				}
			}

			public string TmNumber
			{
				get
				{
					return tmNumber;
				}
				set	
				{
					tmNumber = value;
				}
			}

			public long? SendTime
			{
				get
				{
					return sendTime;
				}
				set	
				{
					sendTime = value;
				}
			}

			public long? AcceptTime
			{
				get
				{
					return acceptTime;
				}
				set	
				{
					acceptTime = value;
				}
			}

			public long? SbjDeadTime
			{
				get
				{
					return sbjDeadTime;
				}
				set	
				{
					sbjDeadTime = value;
				}
			}

			public long? AcceptDeadTime
			{
				get
				{
					return acceptDeadTime;
				}
				set	
				{
					acceptDeadTime = value;
				}
			}

			public string UploadFileTemplateUrl
			{
				get
				{
					return uploadFileTemplateUrl;
				}
				set	
				{
					uploadFileTemplateUrl = value;
				}
			}

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public string BatchNum
			{
				get
				{
					return batchNum;
				}
				set	
				{
					batchNum = value;
				}
			}

			public long? OperateTime
			{
				get
				{
					return operateTime;
				}
				set	
				{
					operateTime = value;
				}
			}

			public List<string> FileTemplateUrls
			{
				get
				{
					return fileTemplateUrls;
				}
				set	
				{
					fileTemplateUrls = value;
				}
			}
		}

		public class QueryTradeMarkApplicationDetail_AdminUploads
		{

			private string loaPicUrl;

			private string licensePicUrl;

			public string LoaPicUrl
			{
				get
				{
					return loaPicUrl;
				}
				set	
				{
					loaPicUrl = value;
				}
			}

			public string LicensePicUrl
			{
				get
				{
					return licensePicUrl;
				}
				set	
				{
					licensePicUrl = value;
				}
			}
		}

		public class QueryTradeMarkApplicationDetail_MaterialDetail
		{

			private string cardNumber;

			private string contactAddress;

			private int? status;

			private string eName;

			private string address;

			private string loaUrl;

			private string city;

			private string passportUrl;

			private string province;

			private string eAddress;

			private string name;

			private string idCardUrl;

			private string businessLicenceUrl;

			private int? type;

			private string expirationDate;

			private string contactZipcode;

			private string town;

			private string contactNumber;

			private string contactEmail;

			private string country;

			private int? region;

			private string contactName;

			private string legalNoticeUrl;

			private string reviewApplicationFile;

			private List<string> reviewAdditionalFiles;

			public string CardNumber
			{
				get
				{
					return cardNumber;
				}
				set	
				{
					cardNumber = value;
				}
			}

			public string ContactAddress
			{
				get
				{
					return contactAddress;
				}
				set	
				{
					contactAddress = value;
				}
			}

			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string EName
			{
				get
				{
					return eName;
				}
				set	
				{
					eName = value;
				}
			}

			public string Address
			{
				get
				{
					return address;
				}
				set	
				{
					address = value;
				}
			}

			public string LoaUrl
			{
				get
				{
					return loaUrl;
				}
				set	
				{
					loaUrl = value;
				}
			}

			public string City
			{
				get
				{
					return city;
				}
				set	
				{
					city = value;
				}
			}

			public string PassportUrl
			{
				get
				{
					return passportUrl;
				}
				set	
				{
					passportUrl = value;
				}
			}

			public string Province
			{
				get
				{
					return province;
				}
				set	
				{
					province = value;
				}
			}

			public string EAddress
			{
				get
				{
					return eAddress;
				}
				set	
				{
					eAddress = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string IdCardUrl
			{
				get
				{
					return idCardUrl;
				}
				set	
				{
					idCardUrl = value;
				}
			}

			public string BusinessLicenceUrl
			{
				get
				{
					return businessLicenceUrl;
				}
				set	
				{
					businessLicenceUrl = value;
				}
			}

			public int? Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string ExpirationDate
			{
				get
				{
					return expirationDate;
				}
				set	
				{
					expirationDate = value;
				}
			}

			public string ContactZipcode
			{
				get
				{
					return contactZipcode;
				}
				set	
				{
					contactZipcode = value;
				}
			}

			public string Town
			{
				get
				{
					return town;
				}
				set	
				{
					town = value;
				}
			}

			public string ContactNumber
			{
				get
				{
					return contactNumber;
				}
				set	
				{
					contactNumber = value;
				}
			}

			public string ContactEmail
			{
				get
				{
					return contactEmail;
				}
				set	
				{
					contactEmail = value;
				}
			}

			public string Country
			{
				get
				{
					return country;
				}
				set	
				{
					country = value;
				}
			}

			public int? Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public string ContactName
			{
				get
				{
					return contactName;
				}
				set	
				{
					contactName = value;
				}
			}

			public string LegalNoticeUrl
			{
				get
				{
					return legalNoticeUrl;
				}
				set	
				{
					legalNoticeUrl = value;
				}
			}

			public string ReviewApplicationFile
			{
				get
				{
					return reviewApplicationFile;
				}
				set	
				{
					reviewApplicationFile = value;
				}
			}

			public List<string> ReviewAdditionalFiles
			{
				get
				{
					return reviewAdditionalFiles;
				}
				set	
				{
					reviewAdditionalFiles = value;
				}
			}
		}

		public class QueryTradeMarkApplicationDetail_FirstClassification
		{

			private string code;

			private string name;

			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}
		}

		public class QueryTradeMarkApplicationDetail_RenewResponse
		{

			private string name;

			private string engName;

			private string address;

			private string engAddress;

			private long? registerTime;

			private long? submitSbjtime;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string EngName
			{
				get
				{
					return engName;
				}
				set	
				{
					engName = value;
				}
			}

			public string Address
			{
				get
				{
					return address;
				}
				set	
				{
					address = value;
				}
			}

			public string EngAddress
			{
				get
				{
					return engAddress;
				}
				set	
				{
					engAddress = value;
				}
			}

			public long? RegisterTime
			{
				get
				{
					return registerTime;
				}
				set	
				{
					registerTime = value;
				}
			}

			public long? SubmitSbjtime
			{
				get
				{
					return submitSbjtime;
				}
				set	
				{
					submitSbjtime = value;
				}
			}
		}

		public class QueryTradeMarkApplicationDetail_ReviewOfficialFiles
		{

			private string reviewAudit;

			private string reviewPass;

			private string reviewKeep;

			private string reviewPart;

			private List<string> reviewSupplements;

			public string ReviewAudit
			{
				get
				{
					return reviewAudit;
				}
				set	
				{
					reviewAudit = value;
				}
			}

			public string ReviewPass
			{
				get
				{
					return reviewPass;
				}
				set	
				{
					reviewPass = value;
				}
			}

			public string ReviewKeep
			{
				get
				{
					return reviewKeep;
				}
				set	
				{
					reviewKeep = value;
				}
			}

			public string ReviewPart
			{
				get
				{
					return reviewPart;
				}
				set	
				{
					reviewPart = value;
				}
			}

			public List<string> ReviewSupplements
			{
				get
				{
					return reviewSupplements;
				}
				set	
				{
					reviewSupplements = value;
				}
			}
		}
	}
}
