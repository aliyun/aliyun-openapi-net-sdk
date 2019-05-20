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
	public class GetNotaryOrderResponse : AcsResponse
	{

		private string requestId;

		private long? notaryOrderId;

		private string aliyunOrderId;

		private string tmRegisterNo;

		private string tmName;

		private string tmImage;

		private string tmClassification;

		private float? orderPrice;

		private int? notaryStatus;

		private string type;

		private string name;

		private string phone;

		private string sellerCompanyName;

		private string businessLicenseId;

		private string legalPersonName;

		private string legalPersonPhone;

		private string legalPersonIdCard;

		private string companyContactName;

		private string companyContactPhone;

		private string tmRegisterCertificate;

		private string businessLicense;

		private string tmAcceptCertificate;

		private string sellerFrontOfIdCard;

		private string sellerBackOfIdCard;

		private string tmRegisterChangeCertificate;

		private string receiverName;

		private string receiverAddress;

		private string receiverPhone;

		private string receiverPostalCode;

		private long? orderDate;

		private long? notaryAcceptDate;

		private long? notarySucceedDate;

		private long? notaryFailedDate;

		private string notaryFailedReason;

		private string notaryCertificate;

		private bool? success;

		private string errorMsg;

		private string errorCode;

		private string bizId;

		private int? notaryType;

		private string notaryPlatformName;

		private int? applyPostStatus;

		private string notaryPostReceipt;

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

		public long? NotaryOrderId
		{
			get
			{
				return notaryOrderId;
			}
			set	
			{
				notaryOrderId = value;
			}
		}

		public string AliyunOrderId
		{
			get
			{
				return aliyunOrderId;
			}
			set	
			{
				aliyunOrderId = value;
			}
		}

		public string TmRegisterNo
		{
			get
			{
				return tmRegisterNo;
			}
			set	
			{
				tmRegisterNo = value;
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

		public string TmImage
		{
			get
			{
				return tmImage;
			}
			set	
			{
				tmImage = value;
			}
		}

		public string TmClassification
		{
			get
			{
				return tmClassification;
			}
			set	
			{
				tmClassification = value;
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

		public int? NotaryStatus
		{
			get
			{
				return notaryStatus;
			}
			set	
			{
				notaryStatus = value;
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

		public string Phone
		{
			get
			{
				return phone;
			}
			set	
			{
				phone = value;
			}
		}

		public string SellerCompanyName
		{
			get
			{
				return sellerCompanyName;
			}
			set	
			{
				sellerCompanyName = value;
			}
		}

		public string BusinessLicenseId
		{
			get
			{
				return businessLicenseId;
			}
			set	
			{
				businessLicenseId = value;
			}
		}

		public string LegalPersonName
		{
			get
			{
				return legalPersonName;
			}
			set	
			{
				legalPersonName = value;
			}
		}

		public string LegalPersonPhone
		{
			get
			{
				return legalPersonPhone;
			}
			set	
			{
				legalPersonPhone = value;
			}
		}

		public string LegalPersonIdCard
		{
			get
			{
				return legalPersonIdCard;
			}
			set	
			{
				legalPersonIdCard = value;
			}
		}

		public string CompanyContactName
		{
			get
			{
				return companyContactName;
			}
			set	
			{
				companyContactName = value;
			}
		}

		public string CompanyContactPhone
		{
			get
			{
				return companyContactPhone;
			}
			set	
			{
				companyContactPhone = value;
			}
		}

		public string TmRegisterCertificate
		{
			get
			{
				return tmRegisterCertificate;
			}
			set	
			{
				tmRegisterCertificate = value;
			}
		}

		public string BusinessLicense
		{
			get
			{
				return businessLicense;
			}
			set	
			{
				businessLicense = value;
			}
		}

		public string TmAcceptCertificate
		{
			get
			{
				return tmAcceptCertificate;
			}
			set	
			{
				tmAcceptCertificate = value;
			}
		}

		public string SellerFrontOfIdCard
		{
			get
			{
				return sellerFrontOfIdCard;
			}
			set	
			{
				sellerFrontOfIdCard = value;
			}
		}

		public string SellerBackOfIdCard
		{
			get
			{
				return sellerBackOfIdCard;
			}
			set	
			{
				sellerBackOfIdCard = value;
			}
		}

		public string TmRegisterChangeCertificate
		{
			get
			{
				return tmRegisterChangeCertificate;
			}
			set	
			{
				tmRegisterChangeCertificate = value;
			}
		}

		public string ReceiverName
		{
			get
			{
				return receiverName;
			}
			set	
			{
				receiverName = value;
			}
		}

		public string ReceiverAddress
		{
			get
			{
				return receiverAddress;
			}
			set	
			{
				receiverAddress = value;
			}
		}

		public string ReceiverPhone
		{
			get
			{
				return receiverPhone;
			}
			set	
			{
				receiverPhone = value;
			}
		}

		public string ReceiverPostalCode
		{
			get
			{
				return receiverPostalCode;
			}
			set	
			{
				receiverPostalCode = value;
			}
		}

		public long? OrderDate
		{
			get
			{
				return orderDate;
			}
			set	
			{
				orderDate = value;
			}
		}

		public long? NotaryAcceptDate
		{
			get
			{
				return notaryAcceptDate;
			}
			set	
			{
				notaryAcceptDate = value;
			}
		}

		public long? NotarySucceedDate
		{
			get
			{
				return notarySucceedDate;
			}
			set	
			{
				notarySucceedDate = value;
			}
		}

		public long? NotaryFailedDate
		{
			get
			{
				return notaryFailedDate;
			}
			set	
			{
				notaryFailedDate = value;
			}
		}

		public string NotaryFailedReason
		{
			get
			{
				return notaryFailedReason;
			}
			set	
			{
				notaryFailedReason = value;
			}
		}

		public string NotaryCertificate
		{
			get
			{
				return notaryCertificate;
			}
			set	
			{
				notaryCertificate = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public int? NotaryType
		{
			get
			{
				return notaryType;
			}
			set	
			{
				notaryType = value;
			}
		}

		public string NotaryPlatformName
		{
			get
			{
				return notaryPlatformName;
			}
			set	
			{
				notaryPlatformName = value;
			}
		}

		public int? ApplyPostStatus
		{
			get
			{
				return applyPostStatus;
			}
			set	
			{
				applyPostStatus = value;
			}
		}

		public string NotaryPostReceipt
		{
			get
			{
				return notaryPostReceipt;
			}
			set	
			{
				notaryPostReceipt = value;
			}
		}
	}
}
